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
using elk = Robotics.Elk;

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

        public ZoneChangedGeneratorService(DsspServiceCreationPort creationPort)
			: base(creationPort)
		{
		}
		
		protected override void Start()
		{
			_state.Devices = new elk.ZoneChanged[4];
            byte id = 0;
			foreach (elk.ZoneChanged zoneChanged in _state.Devices)
			{
				zoneChanged.Body.Id = id++;
				zoneChanged.Body.State = ZoneState.NormalShort;
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
                elk.ZoneChanged data = _state.Devices[randomDevice];
                if (data.Body.State == ZoneState.NormalShort)
                {
                    data.Body.State = ZoneState.ViolatedShort;
                }
                else if (data.Body.State == ZoneState.ViolatedShort)
                {
                    data.Body.State = ZoneState.NormalShort;
                }

                _state.Devices[randomDevice] = data;
                yield return TimeoutPort(15000).Receive(
                        dt =>
                        {
                            LogInfo(string.Format("Sending state notification at {0}.", dt));
                            SendNotification(_submgrPort, _state.Devices[randomDevice]);
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
                            SendNotification(_submgrPort, _state.Devices[randomDevice]);
                        }));
                message.ResponsePort.Post(DefaultUpdateResponseType.Instance);
            }

            yield break;
        }
    }
}


