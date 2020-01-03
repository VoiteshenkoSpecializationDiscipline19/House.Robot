using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Ccr.Core;
using Microsoft.Dss.Core.Attributes;
using Microsoft.Dss.ServiceModel.Dssp;
using Microsoft.Dss.ServiceModel.DsspServiceBase;
using Microsoft.Dss.Services.SubscriptionManager;
using W3C.Soap;
using elk =  Robotics.Elk.ZoneSensor;

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

        [Partner("Elk", Contract = elk.Contract.Identifier, CreationPolicy = PartnerCreationPolicy.UseExistingOrCreate, Optional = false)]
        private elk.ElkZoneSensorOperations _elkPort = new elk.ElkZoneSensorOperations();
        private elk.ElkZoneSensorOperations _elkNotifyPort = new elk.ElkZoneSensorOperations();

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

            SubscribeToSensor();
        }

        void SubscribeToSensor()
        {
            elk.Subscribe msg = new elk.Subscribe();
            msg.NotificationPort = _elkNotifyPort;
            _elkPort.Post(msg);


            Activate(Arbiter.Receive<elk.Normal>(true, _elkNotifyPort, NormalHandler));
            Activate(Arbiter.Receive<elk.Triggered>(true, _elkNotifyPort, TriggeredHandler));
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

        public void NormalHandler(elk.Normal message)
        {
            _state.Active = false;
            message.ResponsePort.Post(DefaultUpdateResponseType.Instance);
            _mainPort.Post(new ReceiveNormal());
            //SendNotification<StateAlarm>(_submgrPort, msg);
        }

        public void TriggeredHandler(elk.Triggered message)
        {
            _state.Active = true;
            message.ResponsePort.Post(DefaultUpdateResponseType.Instance);
            _mainPort.Post(new ReceiveTriggered());

            //SendNotification<StateAlarm>(_submgrPort, msg);
        }

        [ServiceHandler(ServiceHandlerBehavior.Exclusive)]
        public IEnumerator<ITask> ReceiveNormalHandler(ReceiveNormal message)
        {
            _state.Active = false;
            message.ResponsePort.Post(_state);

            //SendNotification<StateAlarm>(_submgrPort, msg);

            yield break;
        }

        [ServiceHandler(ServiceHandlerBehavior.Exclusive)]
        public IEnumerator<ITask> ReceiveTriggeredHandler(ReceiveTriggered message)
        {
            _state.Active = true;
            message.ResponsePort.Post(_state);


            //SendNotification<StateAlarm>(_submgrPort, msg);

            yield break;
        }
    }
}


