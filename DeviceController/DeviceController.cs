using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Ccr.Core;
using Microsoft.Dss.Core.Attributes;
using Microsoft.Dss.ServiceModel.Dssp;
using Microsoft.Dss.ServiceModel.DsspServiceBase;
using Microsoft.Dss.Services.SubscriptionManager;
using W3C.Soap;
using Robotics.Elk.ZoneSensor;

namespace DeviceController
{
    [Contract(Contract.Identifier)]
    [DisplayName("DeviceController")]
    [Description("DeviceController service (no description provided)")]
    class DeviceControllerService : DsspServiceBase
    {
        [ServiceState]
        [InitialStatePartner(Optional = false, ServiceUri = "device.config.xml")]
        DeviceControllerState _state = new DeviceControllerState();

        [ServicePort("/DeviceController", AllowMultipleInstances = true)]
        DeviceControllerOperations _mainPort = new DeviceControllerOperations();

        [SubscriptionManagerPartner]
        private SubscriptionManagerPort _submgrPort = new SubscriptionManagerPort();

        public DeviceControllerService(DsspServiceCreationPort creationPort)
            : base(creationPort)
        {
        }

        [ServiceHandler(ServiceHandlerBehavior.Concurrent)]
        public IEnumerator<ITask> SubscribeHandler(Subscribe message)
        {
            SubscribeHelper(_submgrPort, message.Body, message.ResponsePort);
            yield break;
        }

        protected override void Start()
        {
            base.Start();
        }

        [ServiceHandler(ServiceHandlerBehavior.Exclusive)]
        public IEnumerator<ITask> ReceiveUpdatesHandler(ReceiveUpdates message)
        {
            int count = message.Body.Count;
            while (count > 0)
            {
                --count;
                Activate(TimeoutPort(15000).Receive(
                        dt =>
                        {
                            LogInfo(string.Format("Sending state notification at {0}.", dt));
                            SendNotification<StateAlarm>(_submgrPort, new StateAlarm(_state));
                        }));
                message.ResponsePort.Post(DefaultUpdateResponseType.Instance);
            }

            yield break;
        }

        [ServiceHandler(ServiceHandlerBehavior.Exclusive)]
        public IEnumerator<ITask> ReceiveNormalHandler(NormalZoneData message)
        {
            _state.Active = false;
            StateAlarm msg = new StateAlarm(_state);
            msg.ResponsePort.Post(DefaultUpdateResponseType.Instance);
            yield return TimeoutPort(15000).Receive(
                        dt =>
                        {
                            LogInfo(string.Format("Sending state notification at {0}.", dt));
                            SendNotification<StateAlarm>(_submgrPort, msg);
                        });
        }

        [ServiceHandler(ServiceHandlerBehavior.Exclusive)]
        public IEnumerator<ITask> ReceiveTriggeredHandler(TriggeredZoneData message)
        {
            _state.Active = true;
            StateAlarm msg = new StateAlarm(_state);
            msg.ResponsePort.Post(DefaultUpdateResponseType.Instance);
            yield return TimeoutPort(15000).Receive(
                        dt =>
                        {
                            LogInfo(string.Format("Sending state notification at {0}.", dt));
                            SendNotification<StateAlarm>(_submgrPort, msg);
                        });
        }
    }
}


