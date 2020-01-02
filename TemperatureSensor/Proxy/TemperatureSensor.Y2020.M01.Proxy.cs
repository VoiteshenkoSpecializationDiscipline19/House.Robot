//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Reflection.AssemblyVersionAttribute("1.0.0.0")]
[assembly: global::System.Reflection.AssemblyProductAttribute("TemperatureSensor")]
[assembly: global::System.Reflection.AssemblyTitleAttribute("TemperatureSensor")]
[assembly: global::Microsoft.Dss.Core.Attributes.ServiceDeclarationAttribute(global::Microsoft.Dss.Core.Attributes.DssServiceDeclaration.Proxy, SourceAssemblyKey="TemperatureSensor.Y2020.M01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=db8" +
    "9f9e070779560")]
[assembly: global::System.Security.SecurityTransparentAttribute()]
[assembly: global::System.Security.SecurityRulesAttribute(global::System.Security.SecurityRuleSet.Level1)]

namespace TemperatureSensor.Proxy {
    
    
    [global::Microsoft.Dss.Core.Attributes.DataContractAttribute(Namespace="http://schemas.tempuri.org/2020/01/temperaturesensor.html")]
    [global::System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.tempuri.org/2020/01/temperaturesensor.html", ElementName="TemperatureSensorState")]
    public class TemperatureSensorState : global::Microsoft.Dss.Core.IDssSerializable, global::System.ICloneable {
        
        public TemperatureSensorState() {
        }
        
        private double _Temperature;
        
        [global::Microsoft.Dss.Core.Attributes.DataMemberAttribute(Order=-1)]
        [global::System.ComponentModel.DescriptionAttribute("Celsius temperature")]
        public double Temperature {
            get {
                return this._Temperature;
            }
            set {
                this._Temperature = value;
            }
        }
        
        /// <summary>
        ///Copies the data member values of the current TemperatureSensorState to the specified target object
        ///</summary>
        ///<param name="target">target object (must be an instance of)</param>
        public virtual void CopyTo(Microsoft.Dss.Core.IDssSerializable target) {
            global::TemperatureSensor.Proxy.TemperatureSensorState typedTarget = ((global::TemperatureSensor.Proxy.TemperatureSensorState)(target));
            typedTarget._Temperature = this._Temperature;
        }
        
        /// <summary>
        ///Clones TemperatureSensorState
        ///</summary>
        ///<returns>cloned value</returns>
        public virtual object Clone() {
            global::TemperatureSensor.Proxy.TemperatureSensorState target0 = new global::TemperatureSensor.Proxy.TemperatureSensorState();
            this.CopyTo(target0);
            return target0;
        }
        
        /// <summary>
        ///Serializes the data member values of the current TemperatureSensorState to the specified writer
        ///</summary>
        ///<param name="writer">the writer to which to serialize</param>
        public virtual void Serialize(System.IO.BinaryWriter writer) {
            writer.Write(this._Temperature);
        }
        
        /// <summary>
        ///Deserializes TemperatureSensorState
        ///</summary>
        ///<param name="reader">the reader from which to deserialize</param>
        ///<returns>deserialized TemperatureSensorState</returns>
        public virtual object Deserialize(System.IO.BinaryReader reader) {
            this._Temperature = reader.ReadDouble();
            return this;
        }
    }
    
    [global::Microsoft.Dss.Core.Attributes.DataContractAttribute(Namespace="http://schemas.tempuri.org/2020/01/temperaturesensor.html")]
    [global::System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.tempuri.org/2020/01/temperaturesensor.html", ElementName="ReceiveUpdatesRequest")]
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
            global::TemperatureSensor.Proxy.ReceiveUpdatesRequest typedTarget = ((global::TemperatureSensor.Proxy.ReceiveUpdatesRequest)(target));
            typedTarget._Name = this._Name;
            typedTarget._Count = this._Count;
        }
        
        /// <summary>
        ///Clones ReceiveUpdatesRequest
        ///</summary>
        ///<returns>cloned value</returns>
        public virtual object Clone() {
            global::TemperatureSensor.Proxy.ReceiveUpdatesRequest target0 = new global::TemperatureSensor.Proxy.ReceiveUpdatesRequest();
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
    
    [global::Microsoft.Dss.Core.Attributes.DataContractAttribute(Namespace="http://schemas.tempuri.org/2020/01/temperaturesensor.html")]
    [global::System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.tempuri.org/2020/01/temperaturesensor.html", ElementName="TemperatureMessage")]
    public class TemperatureMessage : global::Microsoft.Dss.Core.IDssSerializable, global::System.ICloneable {
        
        public TemperatureMessage() {
        }
        
        private double _Temperature;
        
        [global::Microsoft.Dss.Core.Attributes.DataMemberAttribute(Order=-1)]
        public double Temperature {
            get {
                return this._Temperature;
            }
            set {
                this._Temperature = value;
            }
        }
        
        /// <summary>
        ///Copies the data member values of the current TemperatureMessage to the specified target object
        ///</summary>
        ///<param name="target">target object (must be an instance of)</param>
        public virtual void CopyTo(Microsoft.Dss.Core.IDssSerializable target) {
            global::TemperatureSensor.Proxy.TemperatureMessage typedTarget = ((global::TemperatureSensor.Proxy.TemperatureMessage)(target));
            typedTarget._Temperature = this._Temperature;
        }
        
        /// <summary>
        ///Clones TemperatureMessage
        ///</summary>
        ///<returns>cloned value</returns>
        public virtual object Clone() {
            global::TemperatureSensor.Proxy.TemperatureMessage target0 = new global::TemperatureSensor.Proxy.TemperatureMessage();
            this.CopyTo(target0);
            return target0;
        }
        
        /// <summary>
        ///Serializes the data member values of the current TemperatureMessage to the specified writer
        ///</summary>
        ///<param name="writer">the writer to which to serialize</param>
        public virtual void Serialize(System.IO.BinaryWriter writer) {
            writer.Write(this._Temperature);
        }
        
        /// <summary>
        ///Deserializes TemperatureMessage
        ///</summary>
        ///<param name="reader">the reader from which to deserialize</param>
        ///<returns>deserialized TemperatureMessage</returns>
        public virtual object Deserialize(System.IO.BinaryReader reader) {
            this._Temperature = reader.ReadDouble();
            return this;
        }
    }
    
    [global::System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public class Get : global::Microsoft.Dss.ServiceModel.Dssp.Get<global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType, global:: Microsoft.Ccr.Core.PortSet<global::TemperatureSensor.Proxy.TemperatureSensorState, global:: W3C.Soap.Fault>> {
        
        public Get() {
        }
        
        public Get(global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body) : 
                base(body) {
        }
        
        public Get(global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body, global::Microsoft.Ccr.Core.PortSet<global::TemperatureSensor.Proxy.TemperatureSensorState, global:: W3C.Soap.Fault> responsePort) : 
                base(body, responsePort) {
        }
    }
    
    [global::System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public class ReceiveUpdates : global::Microsoft.Dss.ServiceModel.Dssp.Update<global::TemperatureSensor.Proxy.ReceiveUpdatesRequest, global:: Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<global::Microsoft.Dss.ServiceModel.Dssp.DefaultUpdateResponseType>> {
        
        public ReceiveUpdates() {
        }
        
        public ReceiveUpdates(global::TemperatureSensor.Proxy.ReceiveUpdatesRequest body) : 
                base(body) {
        }
        
        public ReceiveUpdates(global::TemperatureSensor.Proxy.ReceiveUpdatesRequest body, global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<global::Microsoft.Dss.ServiceModel.Dssp.DefaultUpdateResponseType> responsePort) : 
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
    public class TemperatureSensorOperations : global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup, global:: Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop, global:: TemperatureSensor.Proxy.Get, global:: TemperatureSensor.Proxy.ReceiveUpdates, global:: TemperatureSensor.Proxy.Subscribe> {
        
        public TemperatureSensorOperations() {
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
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::TemperatureSensor.Proxy.TemperatureSensorState, global:: W3C.Soap.Fault> Get() {
            global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType();
            global::TemperatureSensor.Proxy.Get operation = new global::TemperatureSensor.Proxy.Get(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice Get(out global::TemperatureSensor.Proxy.Get operation) {
            global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType();
            operation = new global::TemperatureSensor.Proxy.Get(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::TemperatureSensor.Proxy.TemperatureSensorState, global:: W3C.Soap.Fault> Get(global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType();
            }
            global::TemperatureSensor.Proxy.Get operation = new global::TemperatureSensor.Proxy.Get(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice Get(global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body, out global::TemperatureSensor.Proxy.Get operation) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType();
            }
            operation = new global::TemperatureSensor.Proxy.Get(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<global::Microsoft.Dss.ServiceModel.Dssp.DefaultUpdateResponseType> ReceiveUpdates(string name, int count) {
            global::TemperatureSensor.Proxy.ReceiveUpdatesRequest body = new global::TemperatureSensor.Proxy.ReceiveUpdatesRequest(name, count);
            global::TemperatureSensor.Proxy.ReceiveUpdates operation = new global::TemperatureSensor.Proxy.ReceiveUpdates(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice ReceiveUpdates(string name, int count, out global::TemperatureSensor.Proxy.ReceiveUpdates operation) {
            global::TemperatureSensor.Proxy.ReceiveUpdatesRequest body = new global::TemperatureSensor.Proxy.ReceiveUpdatesRequest(name, count);
            operation = new global::TemperatureSensor.Proxy.ReceiveUpdates(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<global::Microsoft.Dss.ServiceModel.Dssp.DefaultUpdateResponseType> ReceiveUpdates(global::TemperatureSensor.Proxy.ReceiveUpdatesRequest body) {
            if ((body == null)) {
                body = new global::TemperatureSensor.Proxy.ReceiveUpdatesRequest();
            }
            global::TemperatureSensor.Proxy.ReceiveUpdates operation = new global::TemperatureSensor.Proxy.ReceiveUpdates(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice ReceiveUpdates(global::TemperatureSensor.Proxy.ReceiveUpdatesRequest body, out global::TemperatureSensor.Proxy.ReceiveUpdates operation) {
            if ((body == null)) {
                body = new global::TemperatureSensor.Proxy.ReceiveUpdatesRequest();
            }
            operation = new global::TemperatureSensor.Proxy.ReceiveUpdates(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.SubscribeResponseType, global:: W3C.Soap.Fault> Subscribe(global::Microsoft.Ccr.Core.IPort notificationPort, params System.Type[] types) {
            global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType();
            global::TemperatureSensor.Proxy.Subscribe operation = new global::TemperatureSensor.Proxy.Subscribe(body);
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
        
        public virtual global::Microsoft.Ccr.Core.Choice Subscribe(global::Microsoft.Ccr.Core.IPort notificationPort, out global::TemperatureSensor.Proxy.Subscribe operation, params System.Type[] types) {
            global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType();
            operation = new global::TemperatureSensor.Proxy.Subscribe(body);
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
            global::TemperatureSensor.Proxy.Subscribe operation = new global::TemperatureSensor.Proxy.Subscribe(body);
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
        
        public virtual global::Microsoft.Ccr.Core.Choice Subscribe(global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType body, global::Microsoft.Ccr.Core.IPort notificationPort, out global::TemperatureSensor.Proxy.Subscribe operation, params System.Type[] types) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType();
            }
            operation = new global::TemperatureSensor.Proxy.Subscribe(body);
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
    [global::System.ComponentModel.DescriptionAttribute("TemperatureSensor service (no description provided)")]
    [global::System.ComponentModel.DisplayNameAttribute("TemperatureSensor")]
    public class Contract {
        
        public const string Identifier = "http://schemas.tempuri.org/2020/01/temperaturesensor.html";
        
        /// <summary>Creates a new instance of the service.</summary>
        /// <param name="constructorServicePort">Service constructor port</param>
        /// <param name="service">service path</param>
        /// <param name="partners">the partners of the service instance</param>
        /// <returns>create service response port</returns>
        public static global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse> CreateService(global::Microsoft.Dss.Services.Constructor.ConstructorPort constructorServicePort, string service, params Microsoft.Dss.ServiceModel.Dssp.PartnerType[] partners) {
            global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse> result = new global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse>();
            global::Microsoft.Dss.ServiceModel.Dssp.ServiceInfoType serviceInfo = new global::Microsoft.Dss.ServiceModel.Dssp.ServiceInfoType("http://schemas.tempuri.org/2020/01/temperaturesensor.html", service);
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
            global::Microsoft.Dss.ServiceModel.Dssp.ServiceInfoType serviceInfo = new global::Microsoft.Dss.ServiceModel.Dssp.ServiceInfoType("http://schemas.tempuri.org/2020/01/temperaturesensor.html", null);
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
            this.TemperatureSensorOperations = new global::TemperatureSensor.Proxy.TemperatureSensorOperations();
            base.Initialize(new global::Microsoft.Dss.Core.DssOperationsPortMetadata(this.TemperatureSensorOperations, "http://schemas.tempuri.org/2020/01/temperaturesensor.html", "TemperatureSensorOperations", ""));
        }
        
        public global::TemperatureSensor.Proxy.TemperatureSensorOperations TemperatureSensorOperations;
    }
}
