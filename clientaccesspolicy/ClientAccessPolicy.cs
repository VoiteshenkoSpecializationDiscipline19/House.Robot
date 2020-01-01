using System.ComponentModel;
using Microsoft.Dss.Core.Attributes;
using Microsoft.Dss.ServiceModel.Dssp;
using Microsoft.Dss.ServiceModel.DsspServiceBase;

namespace ClientAccessPolicy
{
    [Contract(Contract.Identifier)]
    [DisplayName("ClientAccessPolicy")]
    [Description("Provides clientaccesspolicy.xml for Silverlight applications")]
    class ClientAccessPolicyService : DsspServiceBase
    {
        [ServiceState]
        ClientAccessPolicyState _state = new ClientAccessPolicyState();

        [ServicePort("/clientaccesspolicy.xml", AllowMultipleInstances = false)]
        ClientAccessPolicyOperations _mainPort = new ClientAccessPolicyOperations();

        public ClientAccessPolicyService(DsspServiceCreationPort creationPort)
            : base(creationPort)
        {
        }

        protected override void Start()
        {
            base.Start();
        }
    }
}


