//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Reflection.AssemblyVersionAttribute("0.0.0.0")]
[assembly: global::Microsoft.Dss.Core.Attributes.ServiceDeclarationAttribute(global::Microsoft.Dss.Core.Attributes.DssServiceDeclaration.Proxy, SourceAssemblyKey="ElkDevices.Y2008.M04, Version=0.0.0.0, Culture=neutral, PublicKeyToken=d08de22851" +
    "75fb3a")]
[assembly: global::System.Security.SecurityTransparentAttribute()]
[assembly: global::System.Security.SecurityRulesAttribute(global::System.Security.SecurityRuleSet.Level1)]

namespace Robotics.Elk.ZoneSensor.Proxy {
    
    
    [global::Microsoft.Dss.Core.Attributes.DataContractAttribute(Namespace="http://house.robot/2008/04/elkzonesensor.html")]
    [global::System.Xml.Serialization.XmlRootAttribute(Namespace="http://house.robot/2008/04/elkzonesensor.html", ElementName="SensorState")]
    public class SensorState : global::Microsoft.Dss.Core.IDssSerializable, global::System.ICloneable {
        
        public SensorState() {
        }
        
        private int _Id;
        
        [global::Microsoft.Dss.Core.Attributes.DataMemberAttribute(IsRequired=true, Order=-1)]
        public int Id {
            get {
                return this._Id;
            }
            set {
                this._Id = value;
            }
        }
        
        private string _DisplayName;
        
        [global::Microsoft.Dss.Core.Attributes.DataMemberAttribute(Order=-1)]
        [global::System.ComponentModel.DisplayNameAttribute("Display Name")]
        public string DisplayName {
            get {
                return this._DisplayName;
            }
            set {
                this._DisplayName = value;
            }
        }
        
        private global::Robotics.Elk.ZoneSensor.Proxy.ZoneStatus _Status;
        
        [global::Microsoft.Dss.Core.Attributes.DataMemberAttribute(Order=-1)]
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public global::Robotics.Elk.ZoneSensor.Proxy.ZoneStatus Status {
            get {
                return this._Status;
            }
            set {
                this._Status = value;
            }
        }
        
        private global::System.DateTime _TimeStamp;
        
        [global::Microsoft.Dss.Core.Attributes.DataMemberAttribute(Order=-1)]
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public global::System.DateTime TimeStamp {
            get {
                return this._TimeStamp;
            }
            set {
                this._TimeStamp = value;
            }
        }
        
        /// <summary>
        ///Copies the data member values of the current SensorState to the specified target object
        ///</summary>
        ///<param name="target">target object (must be an instance of)</param>
        public virtual void CopyTo(Microsoft.Dss.Core.IDssSerializable target) {
            global::Robotics.Elk.ZoneSensor.Proxy.SensorState typedTarget = ((global::Robotics.Elk.ZoneSensor.Proxy.SensorState)(target));
            typedTarget._Id = this._Id;
            typedTarget._DisplayName = this._DisplayName;
            typedTarget._Status = this._Status;
            typedTarget._TimeStamp = this._TimeStamp;
        }
        
        /// <summary>
        ///Clones SensorState
        ///</summary>
        ///<returns>cloned value</returns>
        public virtual object Clone() {
            global::Robotics.Elk.ZoneSensor.Proxy.SensorState target0 = new global::Robotics.Elk.ZoneSensor.Proxy.SensorState();
            this.CopyTo(target0);
            return target0;
        }
        
        /// <summary>
        ///Serializes the data member values of the current SensorState to the specified writer
        ///</summary>
        ///<param name="writer">the writer to which to serialize</param>
        public virtual void Serialize(System.IO.BinaryWriter writer) {
            writer.Write(this._Id);
            if ((this._DisplayName == null)) {
                writer.Write(((byte)(0)));
            }
            else {
                writer.Write(((byte)(1)));
                writer.Write(this._DisplayName);
            }
            writer.Write(((int)(this._Status)));
            global::Microsoft.Dss.Services.Serializer.BinarySerializationHelper.SerializeDateTime(this._TimeStamp, writer);
        }
        
        /// <summary>
        ///Deserializes SensorState
        ///</summary>
        ///<param name="reader">the reader from which to deserialize</param>
        ///<returns>deserialized SensorState</returns>
        public virtual object Deserialize(System.IO.BinaryReader reader) {
            this._Id = reader.ReadInt32();
            if ((reader.ReadByte() != 0)) {
                this._DisplayName = reader.ReadString();
            }
            this._Status = ((global::Robotics.Elk.ZoneSensor.Proxy.ZoneStatus)(reader.ReadInt32()));
            this._TimeStamp = global::Microsoft.Dss.Services.Serializer.BinarySerializationHelper.DeserializeDateTime(reader);
            return this;
        }
    }
    
    [global::Microsoft.Dss.Core.Attributes.DataContractAttribute(Namespace="http://house.robot/2008/04/elkzonesensor.html")]
    [global::System.Xml.Serialization.XmlRootAttribute(Namespace="http://house.robot/2008/04/elkzonesensor.html", ElementName="TriggeredZoneData")]
    public class TriggeredZoneData : global::Microsoft.Dss.Core.IDssSerializable, global::System.ICloneable {
        
        public TriggeredZoneData() {
        }
        
        private string _DisplayName;
        
        [global::Microsoft.Dss.Core.Attributes.DataMemberAttribute(Order=-1)]
        [global::System.ComponentModel.DisplayNameAttribute("Display Name")]
        public string DisplayName {
            get {
                return this._DisplayName;
            }
            set {
                this._DisplayName = value;
            }
        }
        
        private global::System.DateTime _TimeStamp;
        
        [global::Microsoft.Dss.Core.Attributes.DataMemberAttribute(Order=-1)]
        public global::System.DateTime TimeStamp {
            get {
                return this._TimeStamp;
            }
            set {
                this._TimeStamp = value;
            }
        }
        
        /// <summary>
        ///Copies the data member values of the current TriggeredZoneData to the specified target object
        ///</summary>
        ///<param name="target">target object (must be an instance of)</param>
        public virtual void CopyTo(Microsoft.Dss.Core.IDssSerializable target) {
            global::Robotics.Elk.ZoneSensor.Proxy.TriggeredZoneData typedTarget = ((global::Robotics.Elk.ZoneSensor.Proxy.TriggeredZoneData)(target));
            typedTarget._DisplayName = this._DisplayName;
            typedTarget._TimeStamp = this._TimeStamp;
        }
        
        /// <summary>
        ///Clones TriggeredZoneData
        ///</summary>
        ///<returns>cloned value</returns>
        public virtual object Clone() {
            global::Robotics.Elk.ZoneSensor.Proxy.TriggeredZoneData target0 = new global::Robotics.Elk.ZoneSensor.Proxy.TriggeredZoneData();
            this.CopyTo(target0);
            return target0;
        }
        
        /// <summary>
        ///Serializes the data member values of the current TriggeredZoneData to the specified writer
        ///</summary>
        ///<param name="writer">the writer to which to serialize</param>
        public virtual void Serialize(System.IO.BinaryWriter writer) {
            if ((this._DisplayName == null)) {
                writer.Write(((byte)(0)));
            }
            else {
                writer.Write(((byte)(1)));
                writer.Write(this._DisplayName);
            }
            global::Microsoft.Dss.Services.Serializer.BinarySerializationHelper.SerializeDateTime(this._TimeStamp, writer);
        }
        
        /// <summary>
        ///Deserializes TriggeredZoneData
        ///</summary>
        ///<param name="reader">the reader from which to deserialize</param>
        ///<returns>deserialized TriggeredZoneData</returns>
        public virtual object Deserialize(System.IO.BinaryReader reader) {
            if ((reader.ReadByte() != 0)) {
                this._DisplayName = reader.ReadString();
            }
            this._TimeStamp = global::Microsoft.Dss.Services.Serializer.BinarySerializationHelper.DeserializeDateTime(reader);
            return this;
        }
    }
    
    [global::Microsoft.Dss.Core.Attributes.DataContractAttribute(Namespace="http://house.robot/2008/04/elkzonesensor.html")]
    [global::System.Xml.Serialization.XmlRootAttribute(Namespace="http://house.robot/2008/04/elkzonesensor.html", ElementName="NormalZoneData")]
    public class NormalZoneData : global::Microsoft.Dss.Core.IDssSerializable, global::System.ICloneable {
        
        public NormalZoneData() {
        }
        
        private string _DisplayName;
        
        [global::Microsoft.Dss.Core.Attributes.DataMemberAttribute(Order=-1)]
        [global::System.ComponentModel.DisplayNameAttribute("Display Name")]
        public string DisplayName {
            get {
                return this._DisplayName;
            }
            set {
                this._DisplayName = value;
            }
        }
        
        private global::System.DateTime _TimeStamp;
        
        [global::Microsoft.Dss.Core.Attributes.DataMemberAttribute(Order=-1)]
        public global::System.DateTime TimeStamp {
            get {
                return this._TimeStamp;
            }
            set {
                this._TimeStamp = value;
            }
        }
        
        /// <summary>
        ///Copies the data member values of the current NormalZoneData to the specified target object
        ///</summary>
        ///<param name="target">target object (must be an instance of)</param>
        public virtual void CopyTo(Microsoft.Dss.Core.IDssSerializable target) {
            global::Robotics.Elk.ZoneSensor.Proxy.NormalZoneData typedTarget = ((global::Robotics.Elk.ZoneSensor.Proxy.NormalZoneData)(target));
            typedTarget._DisplayName = this._DisplayName;
            typedTarget._TimeStamp = this._TimeStamp;
        }
        
        /// <summary>
        ///Clones NormalZoneData
        ///</summary>
        ///<returns>cloned value</returns>
        public virtual object Clone() {
            global::Robotics.Elk.ZoneSensor.Proxy.NormalZoneData target0 = new global::Robotics.Elk.ZoneSensor.Proxy.NormalZoneData();
            this.CopyTo(target0);
            return target0;
        }
        
        /// <summary>
        ///Serializes the data member values of the current NormalZoneData to the specified writer
        ///</summary>
        ///<param name="writer">the writer to which to serialize</param>
        public virtual void Serialize(System.IO.BinaryWriter writer) {
            if ((this._DisplayName == null)) {
                writer.Write(((byte)(0)));
            }
            else {
                writer.Write(((byte)(1)));
                writer.Write(this._DisplayName);
            }
            global::Microsoft.Dss.Services.Serializer.BinarySerializationHelper.SerializeDateTime(this._TimeStamp, writer);
        }
        
        /// <summary>
        ///Deserializes NormalZoneData
        ///</summary>
        ///<param name="reader">the reader from which to deserialize</param>
        ///<returns>deserialized NormalZoneData</returns>
        public virtual object Deserialize(System.IO.BinaryReader reader) {
            if ((reader.ReadByte() != 0)) {
                this._DisplayName = reader.ReadString();
            }
            this._TimeStamp = global::Microsoft.Dss.Services.Serializer.BinarySerializationHelper.DeserializeDateTime(reader);
            return this;
        }
    }
    
    [global::System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public class Get : global::Microsoft.Dss.ServiceModel.Dssp.Get<global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType, global:: Microsoft.Ccr.Core.PortSet<global::Robotics.Elk.ZoneSensor.Proxy.SensorState, global:: W3C.Soap.Fault>> {
        
        public Get() {
        }
        
        public Get(global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body) : 
                base(body) {
        }
        
        public Get(global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body, global::Microsoft.Ccr.Core.PortSet<global::Robotics.Elk.ZoneSensor.Proxy.SensorState, global:: W3C.Soap.Fault> responsePort) : 
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
    public class ZoneChanged : global::Microsoft.Dss.ServiceModel.Dssp.Update<global::Robotics.Elk.ZoneSensor.Proxy.SensorState, global:: Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<global::Microsoft.Dss.ServiceModel.Dssp.DefaultUpdateResponseType>> {
        
        public ZoneChanged() {
        }
        
        public ZoneChanged(global::Robotics.Elk.ZoneSensor.Proxy.SensorState body) : 
                base(body) {
        }
        
        public ZoneChanged(global::Robotics.Elk.ZoneSensor.Proxy.SensorState body, global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<global::Microsoft.Dss.ServiceModel.Dssp.DefaultUpdateResponseType> responsePort) : 
                base(body, responsePort) {
        }
    }
    
    [global::System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public class Triggered : global::Microsoft.Dss.ServiceModel.Dssp.Update<global::Robotics.Elk.ZoneSensor.Proxy.TriggeredZoneData, global:: Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<global::Microsoft.Dss.ServiceModel.Dssp.DefaultUpdateResponseType>> {
        
        public Triggered() {
        }
        
        public Triggered(global::Robotics.Elk.ZoneSensor.Proxy.TriggeredZoneData body) : 
                base(body) {
        }
        
        public Triggered(global::Robotics.Elk.ZoneSensor.Proxy.TriggeredZoneData body, global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<global::Microsoft.Dss.ServiceModel.Dssp.DefaultUpdateResponseType> responsePort) : 
                base(body, responsePort) {
        }
    }
    
    [global::System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public class Normal : global::Microsoft.Dss.ServiceModel.Dssp.Update<global::Robotics.Elk.ZoneSensor.Proxy.NormalZoneData, global:: Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<global::Microsoft.Dss.ServiceModel.Dssp.DefaultUpdateResponseType>> {
        
        public Normal() {
        }
        
        public Normal(global::Robotics.Elk.ZoneSensor.Proxy.NormalZoneData body) : 
                base(body) {
        }
        
        public Normal(global::Robotics.Elk.ZoneSensor.Proxy.NormalZoneData body, global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<global::Microsoft.Dss.ServiceModel.Dssp.DefaultUpdateResponseType> responsePort) : 
                base(body, responsePort) {
        }
    }
    
    [global::System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public class ElkZoneSensorOperations : global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup, global:: Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop, global:: Robotics.Elk.ZoneSensor.Proxy.Get, global:: Microsoft.Dss.Core.DsspHttp.HttpGet, global:: Robotics.Elk.ZoneSensor.Proxy.Subscribe, global:: Robotics.Elk.ZoneSensor.Proxy.ZoneChanged, global:: Robotics.Elk.ZoneSensor.Proxy.Triggered, global:: Robotics.Elk.ZoneSensor.Proxy.Normal> {
        
        public ElkZoneSensorOperations() {
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
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Robotics.Elk.ZoneSensor.Proxy.SensorState, global:: W3C.Soap.Fault> Get() {
            global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType();
            global::Robotics.Elk.ZoneSensor.Proxy.Get operation = new global::Robotics.Elk.ZoneSensor.Proxy.Get(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice Get(out global::Robotics.Elk.ZoneSensor.Proxy.Get operation) {
            global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType();
            operation = new global::Robotics.Elk.ZoneSensor.Proxy.Get(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Robotics.Elk.ZoneSensor.Proxy.SensorState, global:: W3C.Soap.Fault> Get(global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType();
            }
            global::Robotics.Elk.ZoneSensor.Proxy.Get operation = new global::Robotics.Elk.ZoneSensor.Proxy.Get(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice Get(global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body, out global::Robotics.Elk.ZoneSensor.Proxy.Get operation) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType();
            }
            operation = new global::Robotics.Elk.ZoneSensor.Proxy.Get(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.Core.DsspHttp.HttpResponseType, global::W3C.Soap.Fault> HttpGet() {
            global::Microsoft.Dss.Core.DsspHttp.HttpGetRequestType body = new global::Microsoft.Dss.Core.DsspHttp.HttpGetRequestType();
            global::Microsoft.Dss.Core.DsspHttp.HttpGet operation = new global::Microsoft.Dss.Core.DsspHttp.HttpGet(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice HttpGet(out global::Microsoft.Dss.Core.DsspHttp.HttpGet operation) {
            global::Microsoft.Dss.Core.DsspHttp.HttpGetRequestType body = new global::Microsoft.Dss.Core.DsspHttp.HttpGetRequestType();
            operation = new global::Microsoft.Dss.Core.DsspHttp.HttpGet(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.Core.DsspHttp.HttpResponseType, global::W3C.Soap.Fault> HttpGet(global::Microsoft.Dss.Core.DsspHttp.HttpGetRequestType body) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.Core.DsspHttp.HttpGetRequestType();
            }
            global::Microsoft.Dss.Core.DsspHttp.HttpGet operation = new global::Microsoft.Dss.Core.DsspHttp.HttpGet(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice HttpGet(global::Microsoft.Dss.Core.DsspHttp.HttpGetRequestType body, out global::Microsoft.Dss.Core.DsspHttp.HttpGet operation) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.Core.DsspHttp.HttpGetRequestType();
            }
            operation = new global::Microsoft.Dss.Core.DsspHttp.HttpGet(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.SubscribeResponseType, global:: W3C.Soap.Fault> Subscribe(global::Microsoft.Ccr.Core.IPort notificationPort, params System.Type[] types) {
            global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType();
            global::Robotics.Elk.ZoneSensor.Proxy.Subscribe operation = new global::Robotics.Elk.ZoneSensor.Proxy.Subscribe(body);
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
        
        public virtual global::Microsoft.Ccr.Core.Choice Subscribe(global::Microsoft.Ccr.Core.IPort notificationPort, out global::Robotics.Elk.ZoneSensor.Proxy.Subscribe operation, params System.Type[] types) {
            global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType();
            operation = new global::Robotics.Elk.ZoneSensor.Proxy.Subscribe(body);
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
            global::Robotics.Elk.ZoneSensor.Proxy.Subscribe operation = new global::Robotics.Elk.ZoneSensor.Proxy.Subscribe(body);
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
        
        public virtual global::Microsoft.Ccr.Core.Choice Subscribe(global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType body, global::Microsoft.Ccr.Core.IPort notificationPort, out global::Robotics.Elk.ZoneSensor.Proxy.Subscribe operation, params System.Type[] types) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType();
            }
            operation = new global::Robotics.Elk.ZoneSensor.Proxy.Subscribe(body);
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
        
        public virtual global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<global::Microsoft.Dss.ServiceModel.Dssp.DefaultUpdateResponseType> ZoneChanged() {
            global::Robotics.Elk.ZoneSensor.Proxy.SensorState body = new global::Robotics.Elk.ZoneSensor.Proxy.SensorState();
            global::Robotics.Elk.ZoneSensor.Proxy.ZoneChanged operation = new global::Robotics.Elk.ZoneSensor.Proxy.ZoneChanged(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice ZoneChanged(out global::Robotics.Elk.ZoneSensor.Proxy.ZoneChanged operation) {
            global::Robotics.Elk.ZoneSensor.Proxy.SensorState body = new global::Robotics.Elk.ZoneSensor.Proxy.SensorState();
            operation = new global::Robotics.Elk.ZoneSensor.Proxy.ZoneChanged(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<global::Microsoft.Dss.ServiceModel.Dssp.DefaultUpdateResponseType> ZoneChanged(global::Robotics.Elk.ZoneSensor.Proxy.SensorState body) {
            if ((body == null)) {
                body = new global::Robotics.Elk.ZoneSensor.Proxy.SensorState();
            }
            global::Robotics.Elk.ZoneSensor.Proxy.ZoneChanged operation = new global::Robotics.Elk.ZoneSensor.Proxy.ZoneChanged(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice ZoneChanged(global::Robotics.Elk.ZoneSensor.Proxy.SensorState body, out global::Robotics.Elk.ZoneSensor.Proxy.ZoneChanged operation) {
            if ((body == null)) {
                body = new global::Robotics.Elk.ZoneSensor.Proxy.SensorState();
            }
            operation = new global::Robotics.Elk.ZoneSensor.Proxy.ZoneChanged(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<global::Microsoft.Dss.ServiceModel.Dssp.DefaultUpdateResponseType> Triggered() {
            global::Robotics.Elk.ZoneSensor.Proxy.TriggeredZoneData body = new global::Robotics.Elk.ZoneSensor.Proxy.TriggeredZoneData();
            global::Robotics.Elk.ZoneSensor.Proxy.Triggered operation = new global::Robotics.Elk.ZoneSensor.Proxy.Triggered(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice Triggered(out global::Robotics.Elk.ZoneSensor.Proxy.Triggered operation) {
            global::Robotics.Elk.ZoneSensor.Proxy.TriggeredZoneData body = new global::Robotics.Elk.ZoneSensor.Proxy.TriggeredZoneData();
            operation = new global::Robotics.Elk.ZoneSensor.Proxy.Triggered(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<global::Microsoft.Dss.ServiceModel.Dssp.DefaultUpdateResponseType> Triggered(global::Robotics.Elk.ZoneSensor.Proxy.TriggeredZoneData body) {
            if ((body == null)) {
                body = new global::Robotics.Elk.ZoneSensor.Proxy.TriggeredZoneData();
            }
            global::Robotics.Elk.ZoneSensor.Proxy.Triggered operation = new global::Robotics.Elk.ZoneSensor.Proxy.Triggered(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice Triggered(global::Robotics.Elk.ZoneSensor.Proxy.TriggeredZoneData body, out global::Robotics.Elk.ZoneSensor.Proxy.Triggered operation) {
            if ((body == null)) {
                body = new global::Robotics.Elk.ZoneSensor.Proxy.TriggeredZoneData();
            }
            operation = new global::Robotics.Elk.ZoneSensor.Proxy.Triggered(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<global::Microsoft.Dss.ServiceModel.Dssp.DefaultUpdateResponseType> Normal() {
            global::Robotics.Elk.ZoneSensor.Proxy.NormalZoneData body = new global::Robotics.Elk.ZoneSensor.Proxy.NormalZoneData();
            global::Robotics.Elk.ZoneSensor.Proxy.Normal operation = new global::Robotics.Elk.ZoneSensor.Proxy.Normal(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice Normal(out global::Robotics.Elk.ZoneSensor.Proxy.Normal operation) {
            global::Robotics.Elk.ZoneSensor.Proxy.NormalZoneData body = new global::Robotics.Elk.ZoneSensor.Proxy.NormalZoneData();
            operation = new global::Robotics.Elk.ZoneSensor.Proxy.Normal(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<global::Microsoft.Dss.ServiceModel.Dssp.DefaultUpdateResponseType> Normal(global::Robotics.Elk.ZoneSensor.Proxy.NormalZoneData body) {
            if ((body == null)) {
                body = new global::Robotics.Elk.ZoneSensor.Proxy.NormalZoneData();
            }
            global::Robotics.Elk.ZoneSensor.Proxy.Normal operation = new global::Robotics.Elk.ZoneSensor.Proxy.Normal(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice Normal(global::Robotics.Elk.ZoneSensor.Proxy.NormalZoneData body, out global::Robotics.Elk.ZoneSensor.Proxy.Normal operation) {
            if ((body == null)) {
                body = new global::Robotics.Elk.ZoneSensor.Proxy.NormalZoneData();
            }
            operation = new global::Robotics.Elk.ZoneSensor.Proxy.Normal(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
    }
    
    [global::Microsoft.Dss.Core.Attributes.DataContractAttribute(Namespace="http://house.robot/2008/04/elkzonesensor.html")]
    [global::System.Xml.Serialization.XmlRootAttribute(Namespace="http://house.robot/2008/04/elkzonesensor.html", ElementName="ZoneStatus")]
    public enum ZoneStatus : int {
        
        Normal = 0,
        
        Triggered = 1,
    }
    
    [global::System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    [global::System.ComponentModel.DescriptionAttribute("The ElkZoneSensor Service")]
    [global::System.ComponentModel.DisplayNameAttribute("Elk Zone Sensor")]
    public class Contract {
        
        public const string Identifier = "http://house.robot/2008/04/elkzonesensor.html";
        
        /// <summary>Creates a new instance of the service.</summary>
        /// <param name="constructorServicePort">Service constructor port</param>
        /// <param name="service">service path</param>
        /// <param name="partners">the partners of the service instance</param>
        /// <returns>create service response port</returns>
        public static global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse> CreateService(global::Microsoft.Dss.Services.Constructor.ConstructorPort constructorServicePort, string service, params Microsoft.Dss.ServiceModel.Dssp.PartnerType[] partners) {
            global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse> result = new global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse>();
            global::Microsoft.Dss.ServiceModel.Dssp.ServiceInfoType serviceInfo = new global::Microsoft.Dss.ServiceModel.Dssp.ServiceInfoType("http://house.robot/2008/04/elkzonesensor.html", service);
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
            global::Microsoft.Dss.ServiceModel.Dssp.ServiceInfoType serviceInfo = new global::Microsoft.Dss.ServiceModel.Dssp.ServiceInfoType("http://house.robot/2008/04/elkzonesensor.html", null);
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
            this.ElkZoneSensorOperations = new global::Robotics.Elk.ZoneSensor.Proxy.ElkZoneSensorOperations();
            base.Initialize(new global::Microsoft.Dss.Core.DssOperationsPortMetadata(this.ElkZoneSensorOperations, "http://house.robot/2008/04/elkzonesensor.html", "ElkZoneSensorOperations", ""));
        }
        
        public global::Robotics.Elk.ZoneSensor.Proxy.ElkZoneSensorOperations ElkZoneSensorOperations;
    }
}