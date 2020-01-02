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
[assembly: global::System.Reflection.AssemblyProductAttribute("DeviceController")]
[assembly: global::System.Reflection.AssemblyTitleAttribute("DeviceController")]
[assembly: global::Microsoft.Dss.Core.Attributes.ServiceDeclarationAttribute(global::Microsoft.Dss.Core.Attributes.DssServiceDeclaration.Transform, SourceAssemblyKey="DeviceController.Y2020.M01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c131" +
    "bbd27e23e9e8")]
[assembly: global::System.Security.SecurityTransparentAttribute()]
[assembly: global::System.Security.SecurityRulesAttribute(global::System.Security.SecurityRuleSet.Level1)]

namespace Dss.Transforms.TransformDeviceController {
    
    
    public class Transforms : global::Microsoft.Dss.Core.Transforms.TransformBase {
        
        static Transforms() {
            Register();
        }
        
        public static void Register() {
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::DeviceController.Proxy.DeviceControllerState), new global::Microsoft.Dss.Core.Attributes.Transform(DeviceController_Proxy_DeviceControllerState_TO_DeviceController_DeviceControllerState));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::DeviceController.DeviceControllerState), new global::Microsoft.Dss.Core.Attributes.Transform(DeviceController_DeviceControllerState_TO_DeviceController_Proxy_DeviceControllerState));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::DeviceController.Proxy.ReceiveUpdatesRequest), new global::Microsoft.Dss.Core.Attributes.Transform(DeviceController_Proxy_ReceiveUpdatesRequest_TO_DeviceController_ReceiveUpdatesRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::DeviceController.ReceiveUpdatesRequest), new global::Microsoft.Dss.Core.Attributes.Transform(DeviceController_ReceiveUpdatesRequest_TO_DeviceController_Proxy_ReceiveUpdatesRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::Robotics.Elk.ZoneSensor.Proxy.Normal), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_ZoneSensor_Proxy_Normal_TO_Robotics_Elk_ZoneSensor_Proxy_Normal));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::Robotics.Elk.ZoneSensor.Normal), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_ZoneSensor_Proxy_Normal_TO_Robotics_Elk_ZoneSensor_Proxy_Normal0));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::Robotics.Elk.ZoneSensor.Proxy.NormalZoneData), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_ZoneSensor_Proxy_NormalZoneData_TO_Robotics_Elk_ZoneSensor_Proxy_NormalZoneData));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::Robotics.Elk.ZoneSensor.NormalZoneData), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_ZoneSensor_Proxy_NormalZoneData_TO_Robotics_Elk_ZoneSensor_Proxy_NormalZoneData0));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::Robotics.Elk.ZoneSensor.Proxy.Triggered), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_ZoneSensor_Proxy_Triggered_TO_Robotics_Elk_ZoneSensor_Proxy_Triggered));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::Robotics.Elk.ZoneSensor.Triggered), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_ZoneSensor_Proxy_Triggered_TO_Robotics_Elk_ZoneSensor_Proxy_Triggered0));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::Robotics.Elk.ZoneSensor.Proxy.TriggeredZoneData), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_ZoneSensor_Proxy_TriggeredZoneData_TO_Robotics_Elk_ZoneSensor_Proxy_TriggeredZoneData));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::Robotics.Elk.ZoneSensor.TriggeredZoneData), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_ZoneSensor_Proxy_TriggeredZoneData_TO_Robotics_Elk_ZoneSensor_Proxy_TriggeredZoneData0));
        }
        
        public static object DeviceController_Proxy_DeviceControllerState_TO_DeviceController_DeviceControllerState(object transformFrom) {
            global::DeviceController.DeviceControllerState target = new global::DeviceController.DeviceControllerState();
            global::DeviceController.Proxy.DeviceControllerState from = ((global::DeviceController.Proxy.DeviceControllerState)(transformFrom));
            target.Name = from.Name;
            target.Active = from.Active;
            return target;
        }
        
        public static object DeviceController_DeviceControllerState_TO_DeviceController_Proxy_DeviceControllerState(object transformFrom) {
            global::DeviceController.Proxy.DeviceControllerState target = new global::DeviceController.Proxy.DeviceControllerState();
            global::DeviceController.DeviceControllerState from = ((global::DeviceController.DeviceControllerState)(transformFrom));
            target.Name = from.Name;
            target.Active = from.Active;
            return target;
        }
        
        public static object DeviceController_Proxy_ReceiveUpdatesRequest_TO_DeviceController_ReceiveUpdatesRequest(object transformFrom) {
            global::DeviceController.ReceiveUpdatesRequest target = new global::DeviceController.ReceiveUpdatesRequest();
            global::DeviceController.Proxy.ReceiveUpdatesRequest from = ((global::DeviceController.Proxy.ReceiveUpdatesRequest)(transformFrom));
            target.Name = from.Name;
            target.Count = from.Count;
            return target;
        }
        
        public static object DeviceController_ReceiveUpdatesRequest_TO_DeviceController_Proxy_ReceiveUpdatesRequest(object transformFrom) {
            global::DeviceController.Proxy.ReceiveUpdatesRequest target = new global::DeviceController.Proxy.ReceiveUpdatesRequest();
            global::DeviceController.ReceiveUpdatesRequest from = ((global::DeviceController.ReceiveUpdatesRequest)(transformFrom));
            target.Name = from.Name;
            target.Count = from.Count;
            return target;
        }
        
        private static global::Robotics.Elk.ZoneSensor.Proxy.Normal _cachedInstance0 = new global::Robotics.Elk.ZoneSensor.Proxy.Normal();
        
        private static global::Robotics.Elk.ZoneSensor.Normal _cachedInstance = new global::Robotics.Elk.ZoneSensor.Normal();
        
        public static object Robotics_Elk_ZoneSensor_Proxy_Normal_TO_Robotics_Elk_ZoneSensor_Proxy_Normal(object transformFrom) {
            return _cachedInstance;
        }
        
        public static object Robotics_Elk_ZoneSensor_Proxy_Normal_TO_Robotics_Elk_ZoneSensor_Proxy_Normal0(object transformFrom) {
            return _cachedInstance0;
        }
        
        public static object Robotics_Elk_ZoneSensor_Proxy_NormalZoneData_TO_Robotics_Elk_ZoneSensor_Proxy_NormalZoneData(object transformFrom) {
            global::Robotics.Elk.ZoneSensor.NormalZoneData target = new global::Robotics.Elk.ZoneSensor.NormalZoneData();
            global::Robotics.Elk.ZoneSensor.Proxy.NormalZoneData from = ((global::Robotics.Elk.ZoneSensor.Proxy.NormalZoneData)(transformFrom));
            target.DisplayName = from.DisplayName;
            target.TimeStamp = from.TimeStamp;
            return target;
        }
        
        public static object Robotics_Elk_ZoneSensor_Proxy_NormalZoneData_TO_Robotics_Elk_ZoneSensor_Proxy_NormalZoneData0(object transformFrom) {
            global::Robotics.Elk.ZoneSensor.Proxy.NormalZoneData target = new global::Robotics.Elk.ZoneSensor.Proxy.NormalZoneData();
            global::Robotics.Elk.ZoneSensor.NormalZoneData from = ((global::Robotics.Elk.ZoneSensor.NormalZoneData)(transformFrom));
            target.DisplayName = from.DisplayName;
            target.TimeStamp = from.TimeStamp;
            return target;
        }
        
        private static global::Robotics.Elk.ZoneSensor.Proxy.Triggered _cachedInstance2 = new global::Robotics.Elk.ZoneSensor.Proxy.Triggered();
        
        private static global::Robotics.Elk.ZoneSensor.Triggered _cachedInstance1 = new global::Robotics.Elk.ZoneSensor.Triggered();
        
        public static object Robotics_Elk_ZoneSensor_Proxy_Triggered_TO_Robotics_Elk_ZoneSensor_Proxy_Triggered(object transformFrom) {
            return _cachedInstance1;
        }
        
        public static object Robotics_Elk_ZoneSensor_Proxy_Triggered_TO_Robotics_Elk_ZoneSensor_Proxy_Triggered0(object transformFrom) {
            return _cachedInstance2;
        }
        
        public static object Robotics_Elk_ZoneSensor_Proxy_TriggeredZoneData_TO_Robotics_Elk_ZoneSensor_Proxy_TriggeredZoneData(object transformFrom) {
            global::Robotics.Elk.ZoneSensor.TriggeredZoneData target = new global::Robotics.Elk.ZoneSensor.TriggeredZoneData();
            global::Robotics.Elk.ZoneSensor.Proxy.TriggeredZoneData from = ((global::Robotics.Elk.ZoneSensor.Proxy.TriggeredZoneData)(transformFrom));
            target.DisplayName = from.DisplayName;
            target.TimeStamp = from.TimeStamp;
            return target;
        }
        
        public static object Robotics_Elk_ZoneSensor_Proxy_TriggeredZoneData_TO_Robotics_Elk_ZoneSensor_Proxy_TriggeredZoneData0(object transformFrom) {
            global::Robotics.Elk.ZoneSensor.Proxy.TriggeredZoneData target = new global::Robotics.Elk.ZoneSensor.Proxy.TriggeredZoneData();
            global::Robotics.Elk.ZoneSensor.TriggeredZoneData from = ((global::Robotics.Elk.ZoneSensor.TriggeredZoneData)(transformFrom));
            target.DisplayName = from.DisplayName;
            target.TimeStamp = from.TimeStamp;
            return target;
        }
    }
}
