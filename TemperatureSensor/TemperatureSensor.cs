using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Ccr.Core;
using Microsoft.Dss.Core.Attributes;
using Microsoft.Dss.ServiceModel.Dssp;
using Microsoft.Dss.ServiceModel.DsspServiceBase;
using Microsoft.Dss.Services.SubscriptionManager;
using W3C.Soap;

namespace TemperatureSensor
{
    [Contract(Contract.Identifier)]
    [DisplayName("TemperatureSensor")]
    [Description("TemperatureSensor service (no description provided)")]
    class TemperatureSensorService : DsspServiceBase
    {
        [ServiceState]
        TemperatureSensorState _state = new TemperatureSensorState();

        [ServicePort("/TemperatureSensor", AllowMultipleInstances = true)]
        TemperatureSensorOperations _mainPort = new TemperatureSensorOperations();

        [SubscriptionManagerPartner]
        private SubscriptionManagerPort _submgrPort = new SubscriptionManagerPort();

        public TemperatureSensorService(DsspServiceCreationPort creationPort)
            : base(creationPort)
        {
        }

        protected override void Start()
        {
            base.Start();
            SpawnIterator(TemperatureIterator);
        }

        public IEnumerator<ITask> TemperatureIterator()
        {
            Random random = new Random();
            while (true)
            {
                _state.Temperature = random.NextDouble() * 20.0 + 15;
                yield return TimeoutPort(15000).Receive(
                        dt =>
                        {
                            LogInfo(string.Format("Sending state notification at {0}.", dt));
                            SendNotification(_submgrPort, new TemperatureAlarm(_state.Temperature));
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
            int count = message.Body.Count;
            while (count > 0)
            {
                --count;
                Activate(TimeoutPort(15000).Receive(
                        dt =>
                        {
                            LogInfo(string.Format("Sending state notification at {0}.", dt));
                            SendNotification(_submgrPort, new TemperatureAlarm(_state.Temperature));
                        }));
                message.ResponsePort.Post(DefaultUpdateResponseType.Instance);
            }

            yield break;
        }
    }
}


