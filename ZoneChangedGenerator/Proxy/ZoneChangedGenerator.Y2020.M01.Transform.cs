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
[assembly: global::Microsoft.Dss.Core.Attributes.ServiceDeclarationAttribute(global::Microsoft.Dss.Core.Attributes.DssServiceDeclaration.Transform, SourceAssemblyKey="ZoneChangedGenerator.Y2020.M01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
    "c131bbd27e23e9e8")]
[assembly: global::System.Security.SecurityTransparentAttribute()]
[assembly: global::System.Security.SecurityRulesAttribute(global::System.Security.SecurityRuleSet.Level1)]

namespace Dss.Transforms.TransformZoneChangedGenerator {
    
    
    public class Transforms : global::Microsoft.Dss.Core.Transforms.TransformBase {
        
        static Transforms() {
            Register();
        }
        
        public static void Register() {
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::ZoneChangedGenerator.Proxy.ZoneChangedGeneratorState), new global::Microsoft.Dss.Core.Attributes.Transform(ZoneChangedGenerator_Proxy_ZoneChangedGeneratorState_TO_ZoneChangedGenerator_ZoneChangedGeneratorState));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::ZoneChangedGenerator.ZoneChangedGeneratorState), new global::Microsoft.Dss.Core.Attributes.Transform(ZoneChangedGenerator_ZoneChangedGeneratorState_TO_ZoneChangedGenerator_Proxy_ZoneChangedGeneratorState));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::ZoneChangedGenerator.Proxy.ReceiveUpdatesRequest), new global::Microsoft.Dss.Core.Attributes.Transform(ZoneChangedGenerator_Proxy_ReceiveUpdatesRequest_TO_ZoneChangedGenerator_ReceiveUpdatesRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::ZoneChangedGenerator.ReceiveUpdatesRequest), new global::Microsoft.Dss.Core.Attributes.Transform(ZoneChangedGenerator_ReceiveUpdatesRequest_TO_ZoneChangedGenerator_Proxy_ReceiveUpdatesRequest));
        }
        
        public static object ZoneChangedGenerator_Proxy_ZoneChangedGeneratorState_TO_ZoneChangedGenerator_ZoneChangedGeneratorState(object transformFrom) {
            global::ZoneChangedGenerator.ZoneChangedGeneratorState target = new global::ZoneChangedGenerator.ZoneChangedGeneratorState();
            global::ZoneChangedGenerator.Proxy.ZoneChangedGeneratorState from = ((global::ZoneChangedGenerator.Proxy.ZoneChangedGeneratorState)(transformFrom));
            if ((from.Device != null)) {
                global::Robotics.Elk.Proxy.ZoneChangedData tmp = new global::Robotics.Elk.Proxy.ZoneChangedData();
                ((Microsoft.Dss.Core.IDssSerializable)(from.Device)).CopyTo(((Microsoft.Dss.Core.IDssSerializable)(tmp)));
                target.Device = tmp;
            }
            else {
                target.Device = null;
            }
            return target;
        }
        
        public static object ZoneChangedGenerator_ZoneChangedGeneratorState_TO_ZoneChangedGenerator_Proxy_ZoneChangedGeneratorState(object transformFrom) {
            global::ZoneChangedGenerator.Proxy.ZoneChangedGeneratorState target = new global::ZoneChangedGenerator.Proxy.ZoneChangedGeneratorState();
            global::ZoneChangedGenerator.ZoneChangedGeneratorState from = ((global::ZoneChangedGenerator.ZoneChangedGeneratorState)(transformFrom));
            global::Robotics.Elk.Proxy.ZoneChangedData tmp = from.Device;
            if ((tmp != null)) {
                global::Robotics.Elk.Proxy.ZoneChangedData tmp0 = new global::Robotics.Elk.Proxy.ZoneChangedData();
                ((Microsoft.Dss.Core.IDssSerializable)(tmp)).CopyTo(((Microsoft.Dss.Core.IDssSerializable)(tmp0)));
                target.Device = tmp0;
            }
            return target;
        }
        
        public static object ZoneChangedGenerator_Proxy_ReceiveUpdatesRequest_TO_ZoneChangedGenerator_ReceiveUpdatesRequest(object transformFrom) {
            global::ZoneChangedGenerator.ReceiveUpdatesRequest target = new global::ZoneChangedGenerator.ReceiveUpdatesRequest();
            global::ZoneChangedGenerator.Proxy.ReceiveUpdatesRequest from = ((global::ZoneChangedGenerator.Proxy.ReceiveUpdatesRequest)(transformFrom));
            target.Name = from.Name;
            target.Count = from.Count;
            return target;
        }
        
        public static object ZoneChangedGenerator_ReceiveUpdatesRequest_TO_ZoneChangedGenerator_Proxy_ReceiveUpdatesRequest(object transformFrom) {
            global::ZoneChangedGenerator.Proxy.ReceiveUpdatesRequest target = new global::ZoneChangedGenerator.Proxy.ReceiveUpdatesRequest();
            global::ZoneChangedGenerator.ReceiveUpdatesRequest from = ((global::ZoneChangedGenerator.ReceiveUpdatesRequest)(transformFrom));
            target.Name = from.Name;
            target.Count = from.Count;
            return target;
        }
    }
}
