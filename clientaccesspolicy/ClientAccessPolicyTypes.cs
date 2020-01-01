using System.Diagnostics;
using System.Xml.Linq;
using System.Xml.Serialization;
using Microsoft.Ccr.Core;
using Microsoft.Dss.Core;
using Microsoft.Dss.Core.Attributes;
using Microsoft.Dss.Core.DsspHttp;
using Microsoft.Dss.ServiceModel.Dssp;
using W3C.Soap;

namespace ClientAccessPolicy
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class Contract
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public const string Identifier = "http://house.robot/2008/11/clientaccesspolicy.html";
    }

    /// <summary>
    /// 
    /// </summary>
    [DataContract(ExcludeFromProxy=true)]
    [XmlRoot(ElementName = "access-policy", Namespace=null)]
    public class ClientAccessPolicyState : IDssSerializable
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [XmlElement(ElementName = "cross-domain-access")]
        public XElement CrossDomainAccess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ClientAccessPolicyState()
        {
            CrossDomainAccess = XElement.Parse("<policy><allow-from><domain uri=\"*\"/></allow-from><grant-to><resource path=\"/\" include-subpaths=\"true\"/></grant-to></policy>");
        }

        #region IDssSerializable Members

        /// <summary>
        /// 
        /// </summary>
        public object Clone()
        {
            Debug.Print("Clone");
            return new ClientAccessPolicyState { CrossDomainAccess = this.CrossDomainAccess };
        }

        /// <summary>
        /// 
        /// </summary>
        public void CopyTo(IDssSerializable target)
        {
            Debug.Print("CopyTo");
        }

        /// <summary>
        /// 
        /// </summary>
        public object Deserialize(System.IO.BinaryReader reader)
        {
            Debug.Print("Deserialize");
            return new ClientAccessPolicyState();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Serialize(System.IO.BinaryWriter writer)
        {
            Debug.Print("Deserialize");
        }

        #endregion
    }

    /// <summary>
    /// 
    /// </summary>
    [ServicePort]
    public class ClientAccessPolicyOperations : PortSet<DsspDefaultLookup, DsspDefaultDrop, HttpGet, Get>
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public class Get : Get<GetRequestType, PortSet<ClientAccessPolicyState, Fault>>
    {
        /// <summary>
        /// 
        /// </summary>
        public Get()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public Get(GetRequestType body)
            : base(body)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public Get(GetRequestType body, PortSet<ClientAccessPolicyState, Fault> responsePort)
            : base(body, responsePort)
        {
        }
    }
}


