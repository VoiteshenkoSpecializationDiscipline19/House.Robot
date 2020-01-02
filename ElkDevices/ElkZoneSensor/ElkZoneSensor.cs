using Microsoft.Ccr.Core;
using Microsoft.Dss.Core;
using Microsoft.Dss.Core.Attributes;
using Microsoft.Dss.ServiceModel.Dssp;
using Microsoft.Dss.ServiceModel.DsspServiceBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using W3C.Soap;
using Microsoft.Dss.Services.SubscriptionManager;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Diagnostics;

using elk = Robotics.Elk.Proxy;
using Microsoft.Dss.Services.FileStore;

namespace Robotics.Elk.ZoneSensor
{


    /// <summary>
    /// Implementation class for ElkZoneSensor
    /// </summary>
    [DisplayName("Elk Zone Sensor")]
    [Description("The ElkZoneSensor Service")]
    [Contract(Contract.Identifier)]
    public class ElkZoneSensorService : DsspServiceBase
    {

        /// <summary>
        /// _state
        /// </summary>
        [ServiceState]
        [InitialStatePartner(Optional = false, ServiceUri = "ElkZoneSensor.config.xml")]
        private SensorState _state = null;

        /// <summary>
        /// _main Port
        /// </summary>
        [ServicePort("/elkzonesensor", AllowMultipleInstances = true)]
        private ElkZoneSensorOperations _mainPort = new ElkZoneSensorOperations();

        [SubscriptionManagerPartner]
        private SubscriptionManagerPort _submgrPort = new SubscriptionManagerPort();

        [Partner("Elk", Contract = elk.Contract.Identifier, CreationPolicy = PartnerCreationPolicy.UseExistingOrCreate, Optional = false)]
        private elk.ElkOperations _elkPort = new elk.ElkOperations();
        private elk.ElkOperations _elkNotifyPort = new elk.ElkOperations(); //TODO: how to do this...


        /// <summary>
        /// Default Service Constructor
        /// </summary>
        public ElkZoneSensorService(DsspServiceCreationPort creationPort) :
            base(creationPort)
        {
        }


        /// <summary>
        /// Service Start
        /// </summary>
        protected override void Start()
        {
            base.Start();

            //SubscribeToElk();
        }


        void SubscribeToElk()
        {
            //TODO: Make sure that we get an initial state from the panel when we subscribe.
            var request = new elk.FilteredSubscribeRequest(new int[] { _state.Id });
            //_elkPort.FilteredSubscribe(request, _elkNotifyPort);

           // Activate(Arbiter.Receive<elk.ZoneChangedData>(true, _elkNotifyPort, ZoneChangedElkHandler));
        }


        /// <summary>
        /// This function turns the raw Elk data into higher level ZoneStatus
        /// data and posts it to the main port.
        /// The handler on the main port will update state and
        /// notify subscribers.
        /// </summary>
        /// <param name="data"></param>
        public void ZoneChangedElkHandler(elk.ZoneChangedData data)
        {
            
            var now = DateTime.Now;
            var body = new SensorState{ Id = data.Id, DisplayName = _state.DisplayName, TimeStamp = now };

            switch (data.State)
            {
                case elk.ZoneState.NormalEOL:
                case elk.ZoneState.NormalOpen:
                case elk.ZoneState.NormalShort:
                    body.Status = ZoneStatus.Normal;
                    _mainPort.Post(new ZoneChanged { Body = body });
                    _mainPort.Post(new Normal
                    {
                        Body = new NormalZoneData { DisplayName = _state.DisplayName, TimeStamp = now }
                    });

                    LogVerbose(string.Format("ZoneSensor:{0} State:{1}", data.Id, data.State));
                    break;

                case elk.ZoneState.ViolatedEOL:
                case elk.ZoneState.ViolatedOpen:
                case elk.ZoneState.ViolatedShort:
                    body.Status = ZoneStatus.Triggered;
                    _mainPort.Post(new ZoneChanged { Body = body });
                    _mainPort.Post(new Triggered
                    {
                        Body = new TriggeredZoneData { DisplayName = _state.DisplayName, TimeStamp = now }
                    });

                    LogVerbose(string.Format("ZoneSensor:{0} State:{1}", data.Id, data.State));
                    break;
            }
        }

        /// <summary>
        /// Handle subscriptions to sensor notifications.
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


        ///// <summary>
        ///// Updates sensor state and notifies subscribers.
        ///// </summary>
        ///// <param name="message"></param>
        ///// <returns></returns>
        [ServiceHandler(ServiceHandlerBehavior.Exclusive)]
        public IEnumerator<ITask> ZoneChangedHandler(ZoneChanged message)
        {
            _state.Status = message.Body.Status;
            _state.TimeStamp = DateTime.Now;            

            message.ResponsePort.Post(DefaultUpdateResponseType.Instance);

            SendNotification(_submgrPort, message);
            
            yield break;
        }

        ///// <summary>
        ///// Updates sensor state and notifies subscribers.
        ///// </summary>
        ///// <param name="message"></param>
        ///// <returns></returns>
        [ServiceHandler(ServiceHandlerBehavior.Exclusive)]
        public IEnumerator<ITask> TriggeredHandler(Triggered message)
        {
            _state.Status = ZoneStatus.Triggered;
            _state.TimeStamp = message.Body.TimeStamp;

            message.ResponsePort.Post(DefaultUpdateResponseType.Instance);

            SendNotification(_submgrPort, message);

            yield break;
        }

        ///// <summary>
        ///// Updates sensor state and notifies subscribers.
        ///// </summary>
        ///// <param name="message"></param>
        ///// <returns></returns>
        [ServiceHandler(ServiceHandlerBehavior.Exclusive)]
        public IEnumerator<ITask> NormalHandler(Normal message)
        {
            _state.Status = ZoneStatus.Normal;
            _state.TimeStamp = message.Body.TimeStamp;

            message.ResponsePort.Post(DefaultUpdateResponseType.Instance);

            SendNotification(_submgrPort, message);

            yield break;
        }

    }
}
