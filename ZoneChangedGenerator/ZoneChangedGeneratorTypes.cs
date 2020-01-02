using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Ccr.Core;
using Microsoft.Dss.Core.Attributes;
using Microsoft.Dss.ServiceModel.Dssp;
using Microsoft.Dss.ServiceModel.DsspServiceBase;
using W3C.Soap;
using elk = Robotics.Elk.Proxy;

namespace ZoneChangedGenerator
{
	public sealed class Contract
	{
		[DataMember]
		public const string Identifier = "http://schemas.tempuri.org/2020/01/zonechangedgenerator.html";
	}

	[DataContract]
	public class ZoneChangedGeneratorState
	{
		[DataMember]
		[Description("sensor")]
		public elk.ZoneChangedData Device { get; set; }
	}
	
	[ServicePort]
	public class ZoneChangedGeneratorOperations : PortSet<
        DsspDefaultLookup, 
        DsspDefaultDrop, 
        Get, 
        ReceiveUpdates,
        Subscribe>
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

    [Description("An automatic alarm that fires when temperature changed.")]
    public class ZoneAlarm : Update<elk.ZoneChangedData, DsspResponsePort<DefaultUpdateResponseType>>
    {
        public ZoneAlarm()
        {
        }

        public ZoneAlarm(elk.ZoneChangedData data)
        {
            Body = data;
        }
    }

    public class Subscribe : Subscribe<SubscribeRequestType, PortSet<SubscribeResponseType, Fault>>
    {
    }

    public class Get : Get<GetRequestType, PortSet<ZoneChangedGeneratorState, Fault>>
	{
		public Get()
		{
		}
		
		public Get(GetRequestType body)
			: base(body)
		{
		}
		
		public Get(GetRequestType body, PortSet<ZoneChangedGeneratorState, Fault> responsePort)
			: base(body, responsePort)
		{
		}
	}
}


