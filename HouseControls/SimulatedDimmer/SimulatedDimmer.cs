//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     DSS Runtime Version: 2.0.730.3
//     CLR Runtime Version: 2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Ccr.Core;
using Microsoft.Dss.Core;
using Microsoft.Dss.Core.Attributes;
using Microsoft.Dss.ServiceModel.Dssp;
using Microsoft.Dss.ServiceModel.DsspServiceBase;
using Microsoft.Dss.Core.DsspHttp;
using Microsoft.Dss.Core.DsspHttpUtilities;

using System;
using System.Collections.Generic;
using W3C.Soap;
using xml = System.Xml;
using System.ComponentModel;
using System.IO;

using dimmer = Robotics.GenericHouseControls.Dimmer;
using System.Collections.Specialized;
using System.Net;

namespace Robotics.ZWave.SimulatedDimmer
{


    /// <summary>
    /// House Controls Service
    /// </summary>
    [DisplayName("Simulated Dimmer")]
    [Description("The Simulated Dimmer Switch Service")]
    [Contract(Contract.Identifier)]
    [AlternateContract(dimmer.Contract.Identifier)]
    public class SimulatedDimmerService : DsspServiceBase
    {

        /// <summary>
        /// _state
        /// </summary>
        [ServiceState]
        [InitialStatePartner(Optional = false)]
        private dimmer.GenericDimmerState _state = null;

        /// <summary>
        /// _main Port
        /// </summary>
        [ServicePort("/simulateddimmer", AllowMultipleInstances = true)]
        private dimmer.GenericDimmerOperations _mainPort = new dimmer.GenericDimmerOperations();


        /// <summary>
        /// Default Service Constructor
        /// </summary>
        public SimulatedDimmerService(DsspServiceCreationPort creationPort) :
            base(creationPort)
        {
        }

        /// <summary>
        /// Service Start
        /// </summary>
        protected override void Start()
        {
            base.Start();
        }

        [ServiceHandler(ServiceHandlerBehavior.Concurrent)]
        public IEnumerator<ITask> OnHandler(dimmer.On update)
        {
            LogInfo(string.Format("Simulated Dimmer => Id:{0} On", _state.Id));

            update.ResponsePort.Post(DefaultUpdateResponseType.Instance);
            yield break;
        }

        [ServiceHandler(ServiceHandlerBehavior.Concurrent)]
        public IEnumerator<ITask> OffHandler(dimmer.Off update)
        {
            LogInfo(string.Format("Simulated Dimmer => Id:{0} Off", _state.Id));

            update.ResponsePort.Post(DefaultUpdateResponseType.Instance);
            yield break;
        }

        [ServiceHandler(ServiceHandlerBehavior.Exclusive)]
        public IEnumerator<ITask> SetLevelHandler(dimmer.SetLevel update)
        {
            _state.Level = update.Body.Level;
            LogInfo(string.Format("Simulated Dimmer => Id:{0} Level:{1}", _state.Id, update.Body.Level));

            update.ResponsePort.Post(DefaultUpdateResponseType.Instance);
            yield break;
        }
    }
}
