using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Sockets;
using Microsoft.Ccr.Core;
using Microsoft.Dss.Core.Attributes;
using Microsoft.Dss.ServiceModel.Dssp;
using Microsoft.Dss.ServiceModel.DsspServiceBase;
using Microsoft.Dss.Services.SubscriptionManager;
using W3C.Soap;
using System.Diagnostics;

namespace Robotics.Elk
{
    /// <summary>
    /// Implementation class for Elk
    /// </summary>
    [Contract(Contract.Identifier)]
    [DisplayName("Elk Security Panel")]
    [Description("The Elk Security Panel services provides programmatic access to the Elk security panel.")]
    //[DssServiceDescription] //TODO: link to codeplex site.
    public partial class ElkService : DsspServiceBase
    {
        /// <summary>
        /// _state
        /// </summary>
        [ServiceState]
        [InitialStatePartner(Optional = false, ServiceUri = "ElkService.Config.xml")]
        private ElkState _state = null;

        [SubscriptionManagerPartner]
        private SubscriptionManagerPort _submgrPort = new SubscriptionManagerPort();

        /// <summary>
        /// _main Port
        /// </summary>
        [ServicePort("/elk", AllowMultipleInstances = false)]
        private ElkOperations _mainPort = new ElkOperations();

        private ElkIOPort _ioPort = new ElkIOPort();


        /// <summary>
        /// Default Service Constructor
        /// </summary>
        public ElkService(DsspServiceCreationPort creationPort) :
            base(creationPort)
        {
        }



        /// <summary>
        /// Validate state and start the service.
        /// </summary>
        protected override void Start()
        {
            _state.Initialize();

            base.Start();

            LogInfo("Elk Start");

            MainPortInterleave.CombineWith(new Interleave(
                new ExclusiveReceiverGroup(),
                new ConcurrentReceiverGroup(
                    Arbiter.Receive<string>(true, _ioPort, ElkDataHandler)
                    )));

            SpawnIterator(ElkReader);
        }

        #region Service handlers

        /// <summary>
        /// Handles subscription requests.
        /// </summary>
        /// <param name="subscribe"></param>
        /// <returns></returns>
        [ServiceHandler(ServiceHandlerBehavior.Concurrent)]
        public IEnumerator<ITask> SubscribeHandler(Subscribe subscribe)
        {
            var result = SubscribeHelper(_submgrPort, subscribe.Body, subscribe.ResponsePort);
            yield return result.Choice(
                EmptyHandler,
                ex => LogError("Subscribe failed", ex)
            );
        }

        [ServiceHandler(ServiceHandlerBehavior.Concurrent)]
        public IEnumerator<ITask> FilteredSubscribeHandler(FilteredSubscribe subscribe)
        {
            LogInfo(string.Format("Filtered Subscribe {0}", subscribe.Body.Zones[0]));

            var insert = new InsertSubscription(new InsertSubscriptionMessage(subscribe.Body));
            insert.Body.QueryList = Array.ConvertAll<int, QueryType>(subscribe.Body.Zones, i => new QueryType(i.ToString()));
            insert.Body.FilterType = FilterType.Default; // Or Regex

            _submgrPort.Post(insert);

            yield return insert.ResponsePort.Choice(
                response => subscribe.ResponsePort.Post(response),
                fault => subscribe.ResponsePort.Post(fault)
                );

            yield break;
        }


        [ServiceHandler(ServiceHandlerBehavior.Exclusive)]
        public IEnumerator<ITask> ReplaceZonesHandler(ReplaceZones message)
        {
            message.Body.Zones.CopyTo(_state.Zones, 0); //TODO: Should I loop over this instead? This will overwrite the names too...
            
            message.ResponsePort.Post(DefaultReplaceResponseType.Instance);
            SendNotification(_submgrPort, message);
            yield break;
        }

        [ServiceHandler(ServiceHandlerBehavior.Exclusive)]
        public IEnumerator<ITask> ZoneChangedHandler(ZoneChanged message)
        {
            // Update the zone state and the last zone updated.
            byte id = message.Body.Id;
            _state.LastZoneUpdated.Id = id;
            _state.LastZoneUpdated.Name = _state.Zones[id - 1].Name;
            _state.Zones[id - 1].State = _state.LastZoneUpdated.State = message.Body.State;
            _state.Zones[id - 1].Timestamp = _state.LastZoneUpdated.Timestamp = message.Body.Timestamp;

            message.ResponsePort.Post(DefaultUpdateResponseType.Instance);

            SendNotification(_submgrPort, message, message.Body.Id.ToString()); // Converting the ID back to a string to remove leading zeros if there are any.

            yield break;
        }

        [ServiceHandler(ServiceHandlerBehavior.Exclusive)]
        public IEnumerator<ITask> ReplaceOutputsHandler(ReplaceOutputs message)
        {
            message.Body.Outputs.CopyTo(_state.Outputs, 0);

            message.ResponsePort.Post(DefaultReplaceResponseType.Instance);
            SendNotification(_submgrPort, message);
            yield break;
        }

        [ServiceHandler(ServiceHandlerBehavior.Exclusive)]
        public IEnumerator<ITask> OutputChangedHandler(OutputChanged message)
        {
            // Update the output state and the last output updated.
            byte id = message.Body.Id;
            _state.LastOutputUpdated.Id = id;
            //zap! _state.LastOutputUpdated.Name = _state.Outputs[id - 1].Name;
            _state.Outputs[id - 1].State = _state.LastOutputUpdated.State = message.Body.State;
            _state.Outputs[id - 1].Timestamp = _state.LastOutputUpdated.Timestamp = message.Body.Timestamp;

            message.ResponsePort.Post(DefaultUpdateResponseType.Instance);

            SendNotification(_submgrPort, message, message.Body.Id.ToString()); // Converting the ID back to a string to remove leading zeros if there are any.

            yield break;
        }



        /// <summary>
        /// Custom drop handler that disposes of IDisposable recources.
        /// </summary>
        /// <param name="drop"></param>
        /// <returns></returns>
        [ServiceHandler(ServiceHandlerBehavior.Teardown)]
        public virtual IEnumerator<ITask> DropHandler(DsspDefaultDrop drop)
        {
            if (tcpClient != null)
                ((IDisposable)tcpClient).Dispose();

            base.DefaultDropHandler(drop);

            yield break;
        }

        #endregion
    }
}
