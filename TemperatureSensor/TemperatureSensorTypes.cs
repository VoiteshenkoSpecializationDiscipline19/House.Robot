using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Ccr.Core;
using Microsoft.Dss.Core.Attributes;
using Microsoft.Dss.ServiceModel.Dssp;
using Microsoft.Dss.ServiceModel.DsspServiceBase;
using W3C.Soap;

namespace TemperatureSensor
{
	public sealed class Contract
	{
		[DataMember]
		public const string Identifier = "http://schemas.tempuri.org/2020/01/temperaturesensor.html";
	}
	
	[DataContract]
	public class TemperatureSensorState
	{
        [DataMember]
        [Description("Celsius temperature")]
        public double Temperature { get; set; }
	}
	
	[ServicePort]
	public class TemperatureSensorOperations : PortSet
        <
            DsspDefaultLookup,
            DsspDefaultDrop,
            Get,
            ReceiveUpdates,
            Subscribe
        >
    {

    }

    [DataContract]
    public class ReceiveUpdatesRequest
    {
        [DataMember]
        [DataMemberConstructor]
        public string Name { get; set; }

        [DataMember(IsRequired = true)]
        [DataMemberConstructor]
        public int Count { get; set; }
    }

    public class ReceiveUpdates : Update<ReceiveUpdatesRequest, DsspResponsePort<DefaultUpdateResponseType>>
    {
    }

    [DataContract]
    public class TemperatureMessage
    {
        [DataMember]
        public double Temperature;
    }

    [Description("An automatic alarm that fires when temperature changed.")]
    public class TemperatureAlarm : Update<TemperatureMessage, DsspResponsePort<DefaultUpdateResponseType>>
    {
        public TemperatureAlarm()
        {
        }

        public TemperatureAlarm(double temperatue)
        {
            Body = new TemperatureMessage { Temperature = temperatue };
        }
    }

    public class Subscribe : Subscribe<SubscribeRequestType, PortSet<SubscribeResponseType, Fault>>
    {
    }

    public class Get : Get<GetRequestType, PortSet<TemperatureSensorState, Fault>>
	{
		public Get()
		{
		}
		
		public Get(GetRequestType body)
			: base(body)
		{
		}
		
		public Get(GetRequestType body, PortSet<TemperatureSensorState, Fault> responsePort)
			: base(body, responsePort)
		{
		}
	}
}


