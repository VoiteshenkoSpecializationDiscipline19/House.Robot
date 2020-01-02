//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Reflection.AssemblyVersionAttribute("1.0.0.0")]
[assembly: global::System.Reflection.AssemblyProductAttribute("ZoneChangedGenerator")]
[assembly: global::System.Reflection.AssemblyTitleAttribute("ZoneChangedGenerator")]
[assembly: global::Microsoft.Dss.Core.Attributes.ServiceDeclarationAttribute(global::Microsoft.Dss.Core.Attributes.DssServiceDeclaration.Proxy, SourceAssemblyKey="ZoneChangedGenerator.Y2020.M01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
    "c131bbd27e23e9e8")]
[assembly: global::System.Security.SecurityTransparentAttribute()]
[assembly: global::System.Security.SecurityRulesAttribute(global::System.Security.SecurityRuleSet.Level1)]

namespace ZoneChangedGenerator.Proxy {
    
    
    [global::Microsoft.Dss.Core.Attributes.DataContractAttribute(Namespace="http://schemas.tempuri.org/2020/01/zonechangedgenerator.html")]
    [global::System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.tempuri.org/2020/01/zonechangedgenerator.html", ElementName="ZoneChangedGeneratorState")]
    public class ZoneChangedGeneratorState : global::Microsoft.Dss.Core.IDssSerializable, global::System.ICloneable {
        
        public ZoneChangedGeneratorState() {
        }
        
        private global::Robotics.Elk.Proxy.ZoneChangedData _Device;
        
        [global::Microsoft.Dss.Core.Attributes.DataMemberAttribute(Order=-1)]
        [global::System.ComponentModel.DescriptionAttribute("sensor")]
        public global::Robotics.Elk.Proxy.ZoneChangedData Device {
            get {
                return this._Device;
            }
            set {
                this._Device = value;
            }
        }
        
        /// <summary>
        ///Copies the data member values of the current ZoneChangedGeneratorState to the specified target object
        ///</summary>
        ///<param name="target">target object (must be an instance of)</param>
        public virtual void CopyTo(Microsoft.Dss.Core.IDssSerializable target) {
            global::ZoneChangedGenerator.Proxy.ZoneChangedGeneratorState typedTarget = ((global::ZoneChangedGenerator.Proxy.ZoneChangedGeneratorState)(target));
            if ((this._Device != null)) {
                global::Robotics.Elk.Proxy.ZoneChangedData tmp = new global::Robotics.Elk.Proxy.ZoneChangedData();
                ((Microsoft.Dss.Core.IDssSerializable)(this._Device)).CopyTo(((Microsoft.Dss.Core.IDssSerializable)(tmp)));
                typedTarget._Device = tmp;
            }
        }
        
        /// <summary>
        ///Clones ZoneChangedGeneratorState
        ///</summary>
        ///<returns>cloned value</returns>
        public virtual object Clone() {
            global::ZoneChangedGenerator.Proxy.ZoneChangedGeneratorState target0 = new global::ZoneChangedGenerator.Proxy.ZoneChangedGeneratorState();
            this.CopyTo(target0);
            return target0;
        }
        
        /// <summary>
        ///Serializes the data member values of the current ZoneChangedGeneratorState to the specified writer
        ///</summary>
        ///<param name="writer">the writer to which to serialize</param>
        public virtual void Serialize(System.IO.BinaryWriter writer) {
            if ((this._Device == null)) {
                writer.Write(((byte)(0)));
            }
            else {
                writer.Write(((byte)(1)));
                ((Microsoft.Dss.Core.IDssSerializable)(this._Device)).Serialize(writer);
            }
        }
        
        /// <summary>
        ///Deserializes ZoneChangedGeneratorState
        ///</summary>
        ///<param name="reader">the reader from which to deserialize</param>
        ///<returns>deserialized ZoneChangedGeneratorState</returns>
        public virtual object Deserialize(System.IO.BinaryReader reader) {
            if ((reader.ReadByte() != 0)) {
                this._Device = ((global::Robotics.Elk.Proxy.ZoneChangedData)(((Microsoft.Dss.Core.IDssSerializable)(new global::Robotics.Elk.Proxy.ZoneChangedData())).Deserialize(reader)));
            }
            return this;
        }
    }
    
    [global::Microsoft.Dss.Core.Attributes.DataContractAttribute(Namespace="http://schemas.tempuri.org/2020/01/zonechangedgenerator.html")]
    [global::System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.tempuri.org/2020/01/zonechangedgenerator.html", ElementName="ReceiveUpdatesRequest")]
    public class ReceiveUpdatesRequest : global::Microsoft.Dss.Core.IDssSerializable, global::System.ICloneable {
        
        public ReceiveUpdatesRequest() {
        }
        
        public ReceiveUpdatesRequest(string name, int count) {
            this._Name = name;
            this._Count = count;
        }
        
        private string _Name;
        
        [global::Microsoft.Dss.Core.Attributes.DataMemberAttribute(Order=-1)]
        [global::Microsoft.Dss.Core.Attributes.DataMemberConstructorAttribute(Order=1)]
        public string Name {
            get {
                return this._Name;
            }
            set {
                this._Name = value;
            }
        }
        
        private int _Count;
        
        [global::Microsoft.Dss.Core.Attributes.DataMemberAttribute(IsRequired=true, Order=-1)]
        [global::Microsoft.Dss.Core.Attributes.DataMemberConstructorAttribute(Order=2)]
        public int Count {
            get {
                return this._Count;
            }
            set {
                this._Count = value;
            }
        }
        
        /// <summary>
        ///Copies the data member values of the current ReceiveUpdatesRequest to the specified target object
        ///</summary>
        ///<param name="target">target object (must be an instance of)</param>
        public virtual void CopyTo(Microsoft.Dss.Core.IDssSerializable target) {
            global::ZoneChangedGenerator.Proxy.ReceiveUpdatesRequest typedTarget = ((global::ZoneChangedGenerator.Proxy.ReceiveUpdatesRequest)(target));
            typedTarget._Name = this._Name;
            typedTarget._Count = this._Count;
        }
        
        /// <summary>
        ///Clones ReceiveUpdatesRequest
        ///</summary>
        ///<returns>cloned value</returns>
        public virtual object Clone() {
            global::ZoneChangedGenerator.Proxy.ReceiveUpdatesRequest target0 = new global::ZoneChangedGenerator.Proxy.ReceiveUpdatesRequest();
            this.CopyTo(target0);
            return target0;
        }
        
        /// <summary>
        ///Serializes the data member values of the current ReceiveUpdatesRequest to the specified writer
        ///</summary>
        ///<param name="writer">the writer to which to serialize</param>
        public virtual void Serialize(System.IO.BinaryWriter writer) {
            if ((this._Name == null)) {
                writer.Write(((byte)(0)));
            }
            else {
                writer.Write(((byte)(1)));
                writer.Write(this._Name);
            }
            writer.Write(this._Count);
        }
        
        /// <summary>
        ///Deserializes ReceiveUpdatesRequest
        ///</summary>
        ///<param name="reader">the reader from which to deserialize</param>
        ///<returns>deserialized ReceiveUpdatesRequest</returns>
        public virtual object Deserialize(System.IO.BinaryReader reader) {
            if ((reader.ReadByte() != 0)) {
                this._Name = reader.ReadString();
            }
            this._Count = reader.ReadInt32();
            return this;
        }
    }
    
    [global::System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public class Get : global::Microsoft.Dss.ServiceModel.Dssp.Get<global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType, global:: Microsoft.Ccr.Core.PortSet<global::ZoneChangedGenerator.Proxy.ZoneChangedGeneratorState, global:: W3C.Soap.Fault>> {
        
        public Get() {
        }
        
        public Get(global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body) : 
                base(body) {
        }
        
        public Get(global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body, global::Microsoft.Ccr.Core.PortSet<global::ZoneChangedGenerator.Proxy.ZoneChangedGeneratorState, global:: W3C.Soap.Fault> responsePort) : 
                base(body, responsePort) {
        }
    }
    
    [global::System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public class ReceiveUpdates : global::Microsoft.Dss.ServiceModel.Dssp.Update<global::ZoneChangedGenerator.Proxy.ReceiveUpdatesRequest, global:: Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<global::Microsoft.Dss.ServiceModel.Dssp.DefaultUpdateResponseType>> {
        
        public ReceiveUpdates() {
        }
        
        public ReceiveUpdates(global::ZoneChangedGenerator.Proxy.ReceiveUpdatesRequest body) : 
                base(body) {
        }
        
        public ReceiveUpdates(global::ZoneChangedGenerator.Proxy.ReceiveUpdatesRequest body, global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<global::Microsoft.Dss.ServiceModel.Dssp.DefaultUpdateResponseType> responsePort) : 
                base(body, responsePort) {
        }
    }
    
    [global::System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public class Subscribe : global::Microsoft.Dss.ServiceModel.Dssp.Subscribe<global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType, global:: Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.SubscribeResponseType, global:: W3C.Soap.Fault>> {
        
        public Subscribe() {
        }
        
        public Subscribe(global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType body) : 
                base(body) {
        }
        
        public Subscribe(global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType body, global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.SubscribeResponseType, global:: W3C.Soap.Fault> responsePort) : 
                base(body, responsePort) {
        }
    }
    
    [global::System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public class ZoneChangedGeneratorOperations : global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup, global:: Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop, global:: ZoneChangedGenerator.Proxy.Get, global:: ZoneChangedGenerator.Proxy.ReceiveUpdates, global:: ZoneChangedGenerator.Proxy.Subscribe> {
        
        public ZoneChangedGeneratorOperations() {
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.LookupResponse, global::W3C.Soap.Fault> DsspDefaultLookup() {
            global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType();
            global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice DsspDefaultLookup(out global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup operation) {
            global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType();
            operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.LookupResponse, global::W3C.Soap.Fault> DsspDefaultLookup(global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType body) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType();
            }
            global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice DsspDefaultLookup(global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType body, out global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup operation) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType();
            }
            operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.DefaultDropResponseType, global::W3C.Soap.Fault> DsspDefaultDrop() {
            global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType();
            global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice DsspDefaultDrop(out global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop operation) {
            global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType();
            operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.DefaultDropResponseType, global::W3C.Soap.Fault> DsspDefaultDrop(global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType body) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType();
            }
            global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice DsspDefaultDrop(global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType body, out global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop operation) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType();
            }
            operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::ZoneChangedGenerator.Proxy.ZoneChangedGeneratorState, global:: W3C.Soap.Fault> Get() {
            global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType();
            global::ZoneChangedGenerator.Proxy.Get operation = new global::ZoneChangedGenerator.Proxy.Get(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice Get(out global::ZoneChangedGenerator.Proxy.Get operation) {
            global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType();
            operation = new global::ZoneChangedGenerator.Proxy.Get(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::ZoneChangedGenerator.Proxy.ZoneChangedGeneratorState, global:: W3C.Soap.Fault> Get(global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType();
            }
            global::ZoneChangedGenerator.Proxy.Get operation = new global::ZoneChangedGenerator.Proxy.Get(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice Get(global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body, out global::ZoneChangedGenerator.Proxy.Get operation) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType();
            }
            operation = new global::ZoneChangedGenerator.Proxy.Get(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<global::Microsoft.Dss.ServiceModel.Dssp.DefaultUpdateResponseType> ReceiveUpdates(string name, int count) {
            global::ZoneChangedGenerator.Proxy.ReceiveUpdatesRequest body = new global::ZoneChangedGenerator.Proxy.ReceiveUpdatesRequest(name, count);
            global::ZoneChangedGenerator.Proxy.ReceiveUpdates operation = new global::ZoneChangedGenerator.Proxy.ReceiveUpdates(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice ReceiveUpdates(string name, int count, out global::ZoneChangedGenerator.Proxy.ReceiveUpdates operation) {
            global::ZoneChangedGenerator.Proxy.ReceiveUpdatesRequest body = new global::ZoneChangedGenerator.Proxy.ReceiveUpdatesRequest(name, count);
            operation = new global::ZoneChangedGenerator.Proxy.ReceiveUpdates(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<global::Microsoft.Dss.ServiceModel.Dssp.DefaultUpdateResponseType> ReceiveUpdates(global::ZoneChangedGenerator.Proxy.ReceiveUpdatesRequest body) {
            if ((body == null)) {
                body = new global::ZoneChangedGenerator.Proxy.ReceiveUpdatesRequest();
            }
            global::ZoneChangedGenerator.Proxy.ReceiveUpdates operation = new global::ZoneChangedGenerator.Proxy.ReceiveUpdates(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice ReceiveUpdates(global::ZoneChangedGenerator.Proxy.ReceiveUpdatesRequest body, out global::ZoneChangedGenerator.Proxy.ReceiveUpdates operation) {
            if ((body == null)) {
                body = new global::ZoneChangedGenerator.Proxy.ReceiveUpdatesRequest();
            }
            operation = new global::ZoneChangedGenerator.Proxy.ReceiveUpdates(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.SubscribeResponseType, global:: W3C.Soap.Fault> Subscribe(global::Microsoft.Ccr.Core.IPort notificationPort, params System.Type[] types) {
            global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType();
            global::ZoneChangedGenerator.Proxy.Subscribe operation = new global::ZoneChangedGenerator.Proxy.Subscribe(body);
            operation.NotificationPort = notificationPort;
            if ((types != null)) {
                body.TypeFilter = new string[types.Length];
                for (int index = 0; (index < types.Length); index = (index + 1)) {
                    body.TypeFilter[index] = global::Microsoft.Dss.ServiceModel.DsspServiceBase.DsspServiceBase.GetTypeFilterDescription(types[index]);
                }
            }
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice Subscribe(global::Microsoft.Ccr.Core.IPort notificationPort, out global::ZoneChangedGenerator.Proxy.Subscribe operation, params System.Type[] types) {
            global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType();
            operation = new global::ZoneChangedGenerator.Proxy.Subscribe(body);
            operation.NotificationPort = notificationPort;
            if ((types != null)) {
                body.TypeFilter = new string[types.Length];
                for (int index = 0; (index < types.Length); index = (index + 1)) {
                    body.TypeFilter[index] = global::Microsoft.Dss.ServiceModel.DsspServiceBase.DsspServiceBase.GetTypeFilterDescription(types[index]);
                }
            }
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.SubscribeResponseType, global:: W3C.Soap.Fault> Subscribe(global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType body, global::Microsoft.Ccr.Core.IPort notificationPort, params System.Type[] types) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType();
            }
            global::ZoneChangedGenerator.Proxy.Subscribe operation = new global::ZoneChangedGenerator.Proxy.Subscribe(body);
            operation.NotificationPort = notificationPort;
            if ((types != null)) {
                body.TypeFilter = new string[types.Length];
                for (int index = 0; (index < types.Length); index = (index + 1)) {
                    body.TypeFilter[index] = global::Microsoft.Dss.ServiceModel.DsspServiceBase.DsspServiceBase.GetTypeFilterDescription(types[index]);
                }
            }
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice Subscribe(global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType body, global::Microsoft.Ccr.Core.IPort notificationPort, out global::ZoneChangedGenerator.Proxy.Subscribe operation, params System.Type[] types) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType();
            }
            operation = new global::ZoneChangedGenerator.Proxy.Subscribe(body);
            operation.NotificationPort = notificationPort;
            if ((types != null)) {
                body.TypeFilter = new string[types.Length];
                for (int index = 0; (index < types.Length); index = (index + 1)) {
                    body.TypeFilter[index] = global::Microsoft.Dss.ServiceModel.DsspServiceBase.DsspServiceBase.GetTypeFilterDescription(types[index]);
                }
            }
            this.Post(operation);
            return operation.ResponsePort;
        }
    }
    
    [global::System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    [global::System.ComponentModel.DescriptionAttribute("ZoneChangedGenerator service (no description provided)")]
    [global::System.ComponentModel.DisplayNameAttribute("ZoneChangedGenerator")]
    public class Contract {
        
        public const string Identifier = "http://schemas.tempuri.org/2020/01/zonechangedgenerator.html";
        
        /// <summary>Creates a new instance of the service.</summary>
        /// <param name="constructorServicePort">Service constructor port</param>
        /// <param name="service">service path</param>
        /// <param name="partners">the partners of the service instance</param>
        /// <returns>create service response port</returns>
        public static global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse> CreateService(global::Microsoft.Dss.Services.Constructor.ConstructorPort constructorServicePort, string service, params Microsoft.Dss.ServiceModel.Dssp.PartnerType[] partners) {
            global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse> result = new global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse>();
            global::Microsoft.Dss.ServiceModel.Dssp.ServiceInfoType serviceInfo = new global::Microsoft.Dss.ServiceModel.Dssp.ServiceInfoType("http://schemas.tempuri.org/2020/01/zonechangedgenerator.html", service);
            if ((partners != null)) {
                serviceInfo.PartnerList = new System.Collections.Generic.List<Microsoft.Dss.ServiceModel.Dssp.PartnerType>(partners);
            }
            global::Microsoft.Dss.Services.Constructor.Create create = new global::Microsoft.Dss.Services.Constructor.Create(serviceInfo, result);
            constructorServicePort.Post(create);
            return result;
        }
        
        /// <summary>Creates a new instance of the service.</summary>
        /// <param name="constructorServicePort">Service constructor port</param>
        /// <param name="partners">the partners of the service instance</param>
        /// <returns>create service response port</returns>
        public static global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse> CreateService(global::Microsoft.Dss.Services.Constructor.ConstructorPort constructorServicePort, params Microsoft.Dss.ServiceModel.Dssp.PartnerType[] partners) {
            global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse> result = new global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse>();
            global::Microsoft.Dss.ServiceModel.Dssp.ServiceInfoType serviceInfo = new global::Microsoft.Dss.ServiceModel.Dssp.ServiceInfoType("http://schemas.tempuri.org/2020/01/zonechangedgenerator.html", null);
            if ((partners != null)) {
                serviceInfo.PartnerList = new System.Collections.Generic.List<Microsoft.Dss.ServiceModel.Dssp.PartnerType>(partners);
            }
            global::Microsoft.Dss.Services.Constructor.Create create = new global::Microsoft.Dss.Services.Constructor.Create(serviceInfo, result);
            constructorServicePort.Post(create);
            return result;
        }
    }
    
    public class CombinedOperationsPort : global::Microsoft.Dss.Core.DssCombinedOperationsPort {
        
        public CombinedOperationsPort() {
            this.ZoneChangedGeneratorOperations = new global::ZoneChangedGenerator.Proxy.ZoneChangedGeneratorOperations();
            base.Initialize(new global::Microsoft.Dss.Core.DssOperationsPortMetadata(this.ZoneChangedGeneratorOperations, "http://schemas.tempuri.org/2020/01/zonechangedgenerator.html", "ZoneChangedGeneratorOperations", ""));
        }
        
        public global::ZoneChangedGenerator.Proxy.ZoneChangedGeneratorOperations ZoneChangedGeneratorOperations;
    }
}