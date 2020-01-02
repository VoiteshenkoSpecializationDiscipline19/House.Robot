using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Ccr.Core;
using Microsoft.Dss.Core.Attributes;
using Microsoft.Dss.ServiceModel.Dssp;
using Microsoft.Dss.ServiceModel.DsspServiceBase;
using W3C.Soap;
using elk = Robotics.Elk.ZoneSensor;

namespace DeviceController
{
	public sealed class Contract
	{
		[DataMember]
		public const string Identifier = "http://schemas.tempuri.org/2020/01/devicecontroller.html";
	}
	
	[DataContract]
	public class DeviceControllerState
	{
        [DataMember]
        [Description("Device name")]
        public string Name { get; set; }
        [DataMember]
        [Description("Device state")]
        public bool Active { get; set; }
    }
	
	[ServicePort]
	public class DeviceControllerOperations : PortSet<
        DsspDefaultLookup,
        DsspDefaultDrop,
        Get,
        ReceiveUpdates,
        Subscribe,
        ReceiveNormal,
        ReceiveTriggered
        >
	{
	}

    public class Subscribe : Subscribe<SubscribeRequestType, PortSet<SubscribeResponseType, Fault>>
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

    [Description("An automatic alarm that fires when state changed.")]
    public class StateAlarm : Update<DeviceControllerState, DsspResponsePort<DefaultUpdateResponseType>>
    {
        public StateAlarm()
        {
        }

        public StateAlarm(string Name, bool Active)
        {
            Body = new DeviceControllerState { Name = Name, Active = Active };
        }

        public StateAlarm(DeviceControllerState state)
        {
            Body = state;
        }
    }

    public class ReceiveNormal : Update<elk.NormalZoneData, DsspResponsePort<DefaultUpdateResponseType>>
    {
    }

    public class ReceiveTriggered : Update<elk.TriggeredZoneData, DsspResponsePort<DefaultUpdateResponseType>>
    {
    }

    public class Get : Get<GetRequestType, PortSet<DeviceControllerState, Fault>>
	{
		public Get()
		{
		}
		
		public Get(GetRequestType body)
			: base(body)
		{
		}
		
		public Get(GetRequestType body, PortSet<DeviceControllerState, Fault> responsePort)
			: base(body, responsePort)
		{
		}
	}
}


