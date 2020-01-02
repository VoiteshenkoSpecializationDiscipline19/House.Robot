using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Ccr.Core;
using Microsoft.Dss.Core.Attributes;
using Microsoft.Dss.ServiceModel.Dssp;
using Microsoft.Dss.ServiceModel.DsspServiceBase;
using Microsoft.Dss.Services.SubscriptionManager;
using Robotics.Elk;
using W3C.Soap;
using elk = Robotics.Elk.Proxy;

namespace ZoneChangedGenerator
{
	[Contract(Contract.Identifier)]
	[DisplayName("ZoneChangedGenerator")]
	[Description("ZoneChangedGenerator service (no description provided)")]
	class ZoneChangedGeneratorService : DsspServiceBase
	{
		[ServiceState]
		ZoneChangedGeneratorState _state = new ZoneChangedGeneratorState();
		
		[ServicePort("/ZoneChangedGenerator", AllowMultipleInstances = true)]
		ZoneChangedGeneratorOperations _mainPort = new ZoneChangedGeneratorOperations();

        [SubscriptionManagerPartner]
        private SubscriptionManagerPort _submgrPort = new SubscriptionManagerPort();

        elk.ZoneChangedData[] devices = new elk.ZoneChangedData[4];

        public ZoneChangedGeneratorService(DsspServiceCreationPort creationPort)
			: base(creationPort)
		{
		}
		
		protected override void Start()
		{
            byte id = 1;
			foreach (elk.ZoneChangedData zoneChanged in devices)
			{
				zoneChanged.Id = id++;
				zoneChanged.State = elk.ZoneState.NormalShort;
			}

			base.Start();
            SpawnIterator(ZoneChangedIterator);
		}

        public IEnumerator<ITask> ZoneChangedIterator()
        {
            Random random = new Random();
            while (true)
            {
                int randomDevice = random.Next() % 4;
                elk.ZoneChangedData data = devices[randomDevice];
                data.Timestamp = DateTime.Now;
                if (data.State == elk.ZoneState.NormalShort)
                {
                    data.State = elk.ZoneState.ViolatedShort;
                }
                else if (data.State == elk.ZoneState.ViolatedShort)
                {
                    data.State = elk.ZoneState.NormalShort;
                }

                devices[randomDevice] = data;
                _state.Device = data;
                yield return TimeoutPort(15000).Receive(
                        dt =>
                        {
                            LogInfo(string.Format("Sending state notification at {0}.", dt));
                            SendNotification(_submgrPort, new ZoneAlarm(devices[randomDevice]));
                        });
            }
        }

        [ServiceHandler(ServiceHandlerBehavior.Concurrent)]
        public IEnumerator<ITask> SubscribeHandler(Subscribe message)
        {
            SubscribeHelper(_submgrPort, message.Body, message.ResponsePort);
            yield break;
        }

        [ServiceHandler(ServiceHandlerBehavior.Concurrent)]
        public IEnumerator<ITask> ReceiveUpdatesHandler(ReceiveUpdates message)
        {
            Random random = new Random();
            
            int count = message.Body.Count;
            while (count > 0)
            {
                int randomDevice = random.Next() % 4;
                --count;
                Activate(TimeoutPort(15000).Receive(
                        dt =>
                        {
                            LogInfo(string.Format("Sending state notification at {0}.", dt));
                            SendNotification(_submgrPort, new ZoneAlarm(devices[randomDevice]));
                        }));
                message.ResponsePort.Post(DefaultUpdateResponseType.Instance);
            }

            yield break;
        }
    }
}


