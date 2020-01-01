using Microsoft.Ccr.Core;
using Microsoft.Dss.Core.Attributes;
using Microsoft.Dss.ServiceModel.Dssp;
using Microsoft.Dss.Core.DsspHttp;

using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using W3C.Soap;
using System.Diagnostics;
using System.Text;

using elk = Robotics.Elk;
using System.ComponentModel;

namespace Robotics.Elk.ZoneSensor
{
    /// <summary>
    /// ElkZoneSensor Contract class
    /// </summary>
    public sealed class Contract
    {

        /// <summary>
        /// The Dss Service contract
        /// </summary>
        [DataMember]
        public const String Identifier = "http://house.robot/2008/04/elkzonesensor.html";
    }


    [DataContract]
    public class SensorState
    {
        [DataMember(IsRequired = true)]
        public int Id { get; set; }

        [DataMember]
        [DisplayName("Display Name")]
        public string DisplayName { get; set; }

        [DataMember]
        [Browsable(false)]
        public ZoneStatus Status { get; set; }

        [DataMember]
        [Browsable(false)]
        public DateTime TimeStamp { get; set; }
    }

    [DataContract]
    public enum ZoneStatus
    {
        Normal,
        Triggered
    }

    /// <summary>
    /// ElkZoneSensor Main Operations Port
    /// </summary>
    [ServicePort]
    public class ElkZoneSensorOperations : PortSet<
        DsspDefaultLookup,
        DsspDefaultDrop,
        Get,
        HttpGet,
        Subscribe,
        ZoneChanged,
        Triggered,
        Normal
        > { }

    /// <summary>
    /// ElkZoneSensor Get Operation
    /// </summary>
    public class Get : Get<GetRequestType, PortSet<SensorState, Fault>>
    {
        /// <summary>
        /// ElkZoneSensor Get Operation
        /// </summary>
        public Get()
        {
        }

        /// <summary>
        /// ElkZoneSensor Get Operation
        /// </summary>
        public Get(Microsoft.Dss.ServiceModel.Dssp.GetRequestType body) :
            base(body)
        {
        }

        /// <summary>
        /// ElkZoneSensor Get Operation
        /// </summary>
        public Get(Microsoft.Dss.ServiceModel.Dssp.GetRequestType body, Microsoft.Ccr.Core.PortSet<SensorState, W3C.Soap.Fault> responsePort) :
            base(body, responsePort)
        {
        }
    }

    public class Subscribe : Subscribe<SubscribeRequestType, PortSet<SubscribeResponseType, Fault>>
    {
    }


    /// <summary>
    /// Indicates that a sensor has changed state. Subscribers to this will get updates when
    /// a zone is triggered or when it goes back to normal.
    /// </summary>
    public class ZoneChanged : Update<SensorState, DsspResponsePort<DefaultUpdateResponseType>>
    {
    }

    [DataContract]
    public class TriggeredZoneData
    {
        [DataMember]
        [DisplayName("Display Name")]
        public string DisplayName { get; set; }

        [DataMember]
        public DateTime TimeStamp { get; set; }
    }

    /// <summary>
    /// Indicates that a zone has been triggered.
    /// </summary>
    public class Triggered : Update<TriggeredZoneData, DsspResponsePort<DefaultUpdateResponseType>>
    {
    }

    [DataContract]
    public class NormalZoneData
    {
        [DataMember]
        [DisplayName("Display Name")]
        public string DisplayName { get; set; }

        [DataMember]
        public DateTime TimeStamp { get; set; }
    }

    /// <summary>
    /// Indicates that a zone has gone back to normal state after having been triggered.
    /// </summary>
    public class Normal : Update<NormalZoneData, DsspResponsePort<DefaultUpdateResponseType>>
    {
    }
}
