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
[assembly: global::Microsoft.Dss.Core.Attributes.ServiceDeclarationAttribute(global::Microsoft.Dss.Core.Attributes.DssServiceDeclaration.Transform, SourceAssemblyKey="ElkService.Y2008.M04, Version=0.0.0.0, Culture=neutral, PublicKeyToken=d08de22851" +
    "75fb3a")]
[assembly: global::System.Security.SecurityTransparentAttribute()]
[assembly: global::System.Security.SecurityRulesAttribute(global::System.Security.SecurityRuleSet.Level1)]

namespace Dss.Transforms.TransformElkService {
    
    
    public class Transforms : global::Microsoft.Dss.Core.Transforms.TransformBase {
        
        static Transforms() {
            Register();
        }
        
        public static void Register() {
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::Robotics.Elk.Proxy.ElkState), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_Proxy_ElkState_TO_Robotics_Elk_ElkState));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::Robotics.Elk.ElkState), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_ElkState_TO_Robotics_Elk_Proxy_ElkState));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::Robotics.Elk.Proxy.Zone), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_Proxy_Zone_TO_Robotics_Elk_Zone));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::Robotics.Elk.Zone), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_Zone_TO_Robotics_Elk_Proxy_Zone));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::Robotics.Elk.Proxy.Output), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_Proxy_Output_TO_Robotics_Elk_Output));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::Robotics.Elk.Output), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_Output_TO_Robotics_Elk_Proxy_Output));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::Robotics.Elk.Proxy.FilteredSubscribeRequest), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_Proxy_FilteredSubscribeRequest_TO_Robotics_Elk_FilteredSubscribeRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::Robotics.Elk.FilteredSubscribeRequest), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_FilteredSubscribeRequest_TO_Robotics_Elk_Proxy_FilteredSubscribeRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::Robotics.Elk.Proxy.ReplaceZonesRequest), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_Proxy_ReplaceZonesRequest_TO_Robotics_Elk_ReplaceZonesRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::Robotics.Elk.ReplaceZonesRequest), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_ReplaceZonesRequest_TO_Robotics_Elk_Proxy_ReplaceZonesRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::Robotics.Elk.Proxy.ZoneChangedData), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_Proxy_ZoneChangedData_TO_Robotics_Elk_ZoneChangedData));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::Robotics.Elk.ZoneChangedData), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_ZoneChangedData_TO_Robotics_Elk_Proxy_ZoneChangedData));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::Robotics.Elk.Proxy.ReplaceOutputData), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_Proxy_ReplaceOutputData_TO_Robotics_Elk_ReplaceOutputData));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::Robotics.Elk.ReplaceOutputData), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_ReplaceOutputData_TO_Robotics_Elk_Proxy_ReplaceOutputData));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::Robotics.Elk.Proxy.OutputChangedData), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_Proxy_OutputChangedData_TO_Robotics_Elk_OutputChangedData));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::Robotics.Elk.OutputChangedData), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_OutputChangedData_TO_Robotics_Elk_Proxy_OutputChangedData));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::Robotics.Elk.Proxy.UpdateTaskRequest), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_Proxy_UpdateTaskRequest_TO_Robotics_Elk_UpdateTaskRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::Robotics.Elk.UpdateTaskRequest), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_UpdateTaskRequest_TO_Robotics_Elk_Proxy_UpdateTaskRequest));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddProxyTransform(typeof(global::Robotics.Elk.Proxy.StringName), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_Proxy_StringName_TO_Robotics_Elk_StringName));
            global::Microsoft.Dss.Core.Transforms.TransformBase.AddSourceTransform(typeof(global::Robotics.Elk.StringName), new global::Microsoft.Dss.Core.Attributes.Transform(Robotics_Elk_StringName_TO_Robotics_Elk_Proxy_StringName));
        }
        
        public static object Robotics_Elk_Proxy_ElkState_TO_Robotics_Elk_ElkState(object transformFrom) {
            global::Robotics.Elk.ElkState target = new global::Robotics.Elk.ElkState();
            global::Robotics.Elk.Proxy.ElkState from = ((global::Robotics.Elk.Proxy.ElkState)(transformFrom));
            target.HostName = from.HostName;
            target.Port = from.Port;
            if ((from.Zones != null)) {
                int count = from.Zones.Length;
                global::Robotics.Elk.Zone[] tmp = new global::Robotics.Elk.Zone[count];
                for (int index = 0; (index < count); index = (index + 1)) {
                    global::Robotics.Elk.Zone tmp0 = default(global::Robotics.Elk.Zone);
                    if ((from.Zones[index] != null)) {
                        tmp0 = ((global::Robotics.Elk.Zone)(Robotics_Elk_Proxy_Zone_TO_Robotics_Elk_Zone(from.Zones[index])));
                    }
                    else {
                        tmp0 = null;
                    }
                    tmp[index] = tmp0;
                }
                target.Zones = tmp;
            }
            else {
                target.Zones = null;
            }
            if ((from.Outputs != null)) {
                int count0 = from.Outputs.Length;
                global::Robotics.Elk.Output[] tmp1 = new global::Robotics.Elk.Output[count0];
                for (int index0 = 0; (index0 < count0); index0 = (index0 + 1)) {
                    global::Robotics.Elk.Output tmp2 = default(global::Robotics.Elk.Output);
                    if ((from.Outputs[index0] != null)) {
                        tmp2 = ((global::Robotics.Elk.Output)(Robotics_Elk_Proxy_Output_TO_Robotics_Elk_Output(from.Outputs[index0])));
                    }
                    else {
                        tmp2 = null;
                    }
                    tmp1[index0] = tmp2;
                }
                target.Outputs = tmp1;
            }
            else {
                target.Outputs = null;
            }
            if ((from.LastZoneUpdated != null)) {
                target.LastZoneUpdated = ((global::Robotics.Elk.Zone)(Robotics_Elk_Proxy_Zone_TO_Robotics_Elk_Zone(from.LastZoneUpdated)));
            }
            else {
                target.LastZoneUpdated = null;
            }
            if ((from.LastOutputUpdated != null)) {
                target.LastOutputUpdated = ((global::Robotics.Elk.Output)(Robotics_Elk_Proxy_Output_TO_Robotics_Elk_Output(from.LastOutputUpdated)));
            }
            else {
                target.LastOutputUpdated = null;
            }
            return target;
        }
        
        public static object Robotics_Elk_ElkState_TO_Robotics_Elk_Proxy_ElkState(object transformFrom) {
            global::Robotics.Elk.Proxy.ElkState target = new global::Robotics.Elk.Proxy.ElkState();
            global::Robotics.Elk.ElkState from = ((global::Robotics.Elk.ElkState)(transformFrom));
            target.HostName = from.HostName;
            target.Port = from.Port;
            Robotics.Elk.Zone[] tmp = from.Zones;
            if ((tmp != null)) {
                int count = tmp.Length;
                global::Robotics.Elk.Proxy.Zone[] tmp0 = new global::Robotics.Elk.Proxy.Zone[count];
                for (int index = 0; (index < count); index = (index + 1)) {
                    global::Robotics.Elk.Proxy.Zone tmp1 = default(global::Robotics.Elk.Proxy.Zone);
                    global::Robotics.Elk.Zone tmp2 = tmp[index];
                    if ((tmp2 != null)) {
                        tmp1 = ((global::Robotics.Elk.Proxy.Zone)(Robotics_Elk_Zone_TO_Robotics_Elk_Proxy_Zone(tmp2)));
                    }
                    tmp0[index] = tmp1;
                }
                target.Zones = tmp0;
            }
            Robotics.Elk.Output[] tmp3 = from.Outputs;
            if ((tmp3 != null)) {
                int count0 = tmp3.Length;
                global::Robotics.Elk.Proxy.Output[] tmp4 = new global::Robotics.Elk.Proxy.Output[count0];
                for (int index0 = 0; (index0 < count0); index0 = (index0 + 1)) {
                    global::Robotics.Elk.Proxy.Output tmp5 = default(global::Robotics.Elk.Proxy.Output);
                    global::Robotics.Elk.Output tmp6 = tmp3[index0];
                    if ((tmp6 != null)) {
                        tmp5 = ((global::Robotics.Elk.Proxy.Output)(Robotics_Elk_Output_TO_Robotics_Elk_Proxy_Output(tmp6)));
                    }
                    tmp4[index0] = tmp5;
                }
                target.Outputs = tmp4;
            }
            global::Robotics.Elk.Zone tmp7 = from.LastZoneUpdated;
            if ((tmp7 != null)) {
                target.LastZoneUpdated = ((global::Robotics.Elk.Proxy.Zone)(Robotics_Elk_Zone_TO_Robotics_Elk_Proxy_Zone(tmp7)));
            }
            global::Robotics.Elk.Output tmp8 = from.LastOutputUpdated;
            if ((tmp8 != null)) {
                target.LastOutputUpdated = ((global::Robotics.Elk.Proxy.Output)(Robotics_Elk_Output_TO_Robotics_Elk_Proxy_Output(tmp8)));
            }
            return target;
        }
        
        public static object Robotics_Elk_Proxy_Zone_TO_Robotics_Elk_Zone(object transformFrom) {
            global::Robotics.Elk.Zone target = new global::Robotics.Elk.Zone();
            global::Robotics.Elk.Proxy.Zone from = ((global::Robotics.Elk.Proxy.Zone)(transformFrom));
            target.Id = from.Id;
            target.Name = from.Name;
            target.State = ((global::Robotics.Elk.ZoneState)(((byte)(from.State))));
            target.Timestamp = from.Timestamp;
            return target;
        }
        
        public static object Robotics_Elk_Zone_TO_Robotics_Elk_Proxy_Zone(object transformFrom) {
            global::Robotics.Elk.Proxy.Zone target = new global::Robotics.Elk.Proxy.Zone();
            global::Robotics.Elk.Zone from = ((global::Robotics.Elk.Zone)(transformFrom));
            target.Id = from.Id;
            target.Name = from.Name;
            target.State = ((global::Robotics.Elk.Proxy.ZoneState)(((byte)(from.State))));
            target.Timestamp = from.Timestamp;
            return target;
        }
        
        public static object Robotics_Elk_Proxy_Output_TO_Robotics_Elk_Output(object transformFrom) {
            global::Robotics.Elk.Output target = new global::Robotics.Elk.Output();
            global::Robotics.Elk.Proxy.Output from = ((global::Robotics.Elk.Proxy.Output)(transformFrom));
            target.Id = from.Id;
            target.State = ((global::Robotics.Elk.OutputState)(((byte)(from.State))));
            target.Timestamp = from.Timestamp;
            return target;
        }
        
        public static object Robotics_Elk_Output_TO_Robotics_Elk_Proxy_Output(object transformFrom) {
            global::Robotics.Elk.Proxy.Output target = new global::Robotics.Elk.Proxy.Output();
            global::Robotics.Elk.Output from = ((global::Robotics.Elk.Output)(transformFrom));
            target.Id = from.Id;
            target.State = ((global::Robotics.Elk.Proxy.OutputState)(((byte)(from.State))));
            target.Timestamp = from.Timestamp;
            return target;
        }
        
        public static object Robotics_Elk_Proxy_FilteredSubscribeRequest_TO_Robotics_Elk_FilteredSubscribeRequest(object transformFrom) {
            global::Robotics.Elk.FilteredSubscribeRequest target = new global::Robotics.Elk.FilteredSubscribeRequest();
            global::Robotics.Elk.Proxy.FilteredSubscribeRequest from = ((global::Robotics.Elk.Proxy.FilteredSubscribeRequest)(transformFrom));
            if ((from.Zones != null)) {
                int count = from.Zones.Length;
                int[] tmp = new int[count];
                global::System.Buffer.BlockCopy(from.Zones, 0, tmp, 0, global::System.Buffer.ByteLength(from.Zones));
                target.Zones = tmp;
            }
            else {
                target.Zones = null;
            }
            target.Subscriber = from.Subscriber;
            target.Expiration = from.Expiration;
            target.NotificationCount = from.NotificationCount;
            if ((from.TypeFilter != null)) {
                int count0 = from.TypeFilter.Length;
                string[] tmp0 = new string[count0];
                from.TypeFilter.CopyTo(tmp0, 0);
                target.TypeFilter = tmp0;
            }
            else {
                target.TypeFilter = null;
            }
            return target;
        }
        
        public static object Robotics_Elk_FilteredSubscribeRequest_TO_Robotics_Elk_Proxy_FilteredSubscribeRequest(object transformFrom) {
            global::Robotics.Elk.Proxy.FilteredSubscribeRequest target = new global::Robotics.Elk.Proxy.FilteredSubscribeRequest();
            global::Robotics.Elk.FilteredSubscribeRequest from = ((global::Robotics.Elk.FilteredSubscribeRequest)(transformFrom));
            int[] tmp = from.Zones;
            if ((tmp != null)) {
                int count = tmp.Length;
                int[] tmp0 = new int[count];
                global::System.Buffer.BlockCopy(tmp, 0, tmp0, 0, global::System.Buffer.ByteLength(tmp));
                target.Zones = tmp0;
            }
            target.Subscriber = from.Subscriber;
            target.Expiration = from.Expiration;
            target.NotificationCount = from.NotificationCount;
            string[] tmp1 = from.TypeFilter;
            if ((tmp1 != null)) {
                int count0 = tmp1.Length;
                string[] tmp2 = new string[count0];
                tmp1.CopyTo(tmp2, 0);
                target.TypeFilter = tmp2;
            }
            return target;
        }
        
        public static object Robotics_Elk_Proxy_ReplaceZonesRequest_TO_Robotics_Elk_ReplaceZonesRequest(object transformFrom) {
            global::Robotics.Elk.ReplaceZonesRequest target = new global::Robotics.Elk.ReplaceZonesRequest();
            global::Robotics.Elk.Proxy.ReplaceZonesRequest from = ((global::Robotics.Elk.Proxy.ReplaceZonesRequest)(transformFrom));
            if ((from.Zones != null)) {
                int count = from.Zones.Length;
                global::Robotics.Elk.Zone[] tmp = new global::Robotics.Elk.Zone[count];
                for (int index = 0; (index < count); index = (index + 1)) {
                    global::Robotics.Elk.Zone tmp0 = default(global::Robotics.Elk.Zone);
                    if ((from.Zones[index] != null)) {
                        tmp0 = ((global::Robotics.Elk.Zone)(Robotics_Elk_Proxy_Zone_TO_Robotics_Elk_Zone(from.Zones[index])));
                    }
                    else {
                        tmp0 = null;
                    }
                    tmp[index] = tmp0;
                }
                target.Zones = tmp;
            }
            else {
                target.Zones = null;
            }
            return target;
        }
        
        public static object Robotics_Elk_ReplaceZonesRequest_TO_Robotics_Elk_Proxy_ReplaceZonesRequest(object transformFrom) {
            global::Robotics.Elk.Proxy.ReplaceZonesRequest target = new global::Robotics.Elk.Proxy.ReplaceZonesRequest();
            global::Robotics.Elk.ReplaceZonesRequest from = ((global::Robotics.Elk.ReplaceZonesRequest)(transformFrom));
            Robotics.Elk.Zone[] tmp = from.Zones;
            if ((tmp != null)) {
                int count = tmp.Length;
                global::Robotics.Elk.Proxy.Zone[] tmp0 = new global::Robotics.Elk.Proxy.Zone[count];
                for (int index = 0; (index < count); index = (index + 1)) {
                    global::Robotics.Elk.Proxy.Zone tmp1 = default(global::Robotics.Elk.Proxy.Zone);
                    global::Robotics.Elk.Zone tmp2 = tmp[index];
                    if ((tmp2 != null)) {
                        tmp1 = ((global::Robotics.Elk.Proxy.Zone)(Robotics_Elk_Zone_TO_Robotics_Elk_Proxy_Zone(tmp2)));
                    }
                    tmp0[index] = tmp1;
                }
                target.Zones = tmp0;
            }
            return target;
        }
        
        public static object Robotics_Elk_Proxy_ZoneChangedData_TO_Robotics_Elk_ZoneChangedData(object transformFrom) {
            global::Robotics.Elk.ZoneChangedData target = new global::Robotics.Elk.ZoneChangedData();
            global::Robotics.Elk.Proxy.ZoneChangedData from = ((global::Robotics.Elk.Proxy.ZoneChangedData)(transformFrom));
            target.Id = from.Id;
            target.State = ((global::Robotics.Elk.ZoneState)(((byte)(from.State))));
            target.Timestamp = from.Timestamp;
            return target;
        }
        
        public static object Robotics_Elk_ZoneChangedData_TO_Robotics_Elk_Proxy_ZoneChangedData(object transformFrom) {
            global::Robotics.Elk.Proxy.ZoneChangedData target = new global::Robotics.Elk.Proxy.ZoneChangedData();
            global::Robotics.Elk.ZoneChangedData from = ((global::Robotics.Elk.ZoneChangedData)(transformFrom));
            target.Id = from.Id;
            target.State = ((global::Robotics.Elk.Proxy.ZoneState)(((byte)(from.State))));
            target.Timestamp = from.Timestamp;
            return target;
        }
        
        public static object Robotics_Elk_Proxy_ReplaceOutputData_TO_Robotics_Elk_ReplaceOutputData(object transformFrom) {
            global::Robotics.Elk.ReplaceOutputData target = new global::Robotics.Elk.ReplaceOutputData();
            global::Robotics.Elk.Proxy.ReplaceOutputData from = ((global::Robotics.Elk.Proxy.ReplaceOutputData)(transformFrom));
            if ((from.Outputs != null)) {
                int count = from.Outputs.Length;
                global::Robotics.Elk.Output[] tmp = new global::Robotics.Elk.Output[count];
                for (int index = 0; (index < count); index = (index + 1)) {
                    global::Robotics.Elk.Output tmp0 = default(global::Robotics.Elk.Output);
                    if ((from.Outputs[index] != null)) {
                        tmp0 = ((global::Robotics.Elk.Output)(Robotics_Elk_Proxy_Output_TO_Robotics_Elk_Output(from.Outputs[index])));
                    }
                    else {
                        tmp0 = null;
                    }
                    tmp[index] = tmp0;
                }
                target.Outputs = tmp;
            }
            else {
                target.Outputs = null;
            }
            return target;
        }
        
        public static object Robotics_Elk_ReplaceOutputData_TO_Robotics_Elk_Proxy_ReplaceOutputData(object transformFrom) {
            global::Robotics.Elk.Proxy.ReplaceOutputData target = new global::Robotics.Elk.Proxy.ReplaceOutputData();
            global::Robotics.Elk.ReplaceOutputData from = ((global::Robotics.Elk.ReplaceOutputData)(transformFrom));
            Robotics.Elk.Output[] tmp = from.Outputs;
            if ((tmp != null)) {
                int count = tmp.Length;
                global::Robotics.Elk.Proxy.Output[] tmp0 = new global::Robotics.Elk.Proxy.Output[count];
                for (int index = 0; (index < count); index = (index + 1)) {
                    global::Robotics.Elk.Proxy.Output tmp1 = default(global::Robotics.Elk.Proxy.Output);
                    global::Robotics.Elk.Output tmp2 = tmp[index];
                    if ((tmp2 != null)) {
                        tmp1 = ((global::Robotics.Elk.Proxy.Output)(Robotics_Elk_Output_TO_Robotics_Elk_Proxy_Output(tmp2)));
                    }
                    tmp0[index] = tmp1;
                }
                target.Outputs = tmp0;
            }
            return target;
        }
        
        public static object Robotics_Elk_Proxy_OutputChangedData_TO_Robotics_Elk_OutputChangedData(object transformFrom) {
            global::Robotics.Elk.OutputChangedData target = new global::Robotics.Elk.OutputChangedData();
            global::Robotics.Elk.Proxy.OutputChangedData from = ((global::Robotics.Elk.Proxy.OutputChangedData)(transformFrom));
            target.Id = from.Id;
            target.State = ((global::Robotics.Elk.OutputState)(((byte)(from.State))));
            target.Timestamp = from.Timestamp;
            return target;
        }
        
        public static object Robotics_Elk_OutputChangedData_TO_Robotics_Elk_Proxy_OutputChangedData(object transformFrom) {
            global::Robotics.Elk.Proxy.OutputChangedData target = new global::Robotics.Elk.Proxy.OutputChangedData();
            global::Robotics.Elk.OutputChangedData from = ((global::Robotics.Elk.OutputChangedData)(transformFrom));
            target.Id = from.Id;
            target.State = ((global::Robotics.Elk.Proxy.OutputState)(((byte)(from.State))));
            target.Timestamp = from.Timestamp;
            return target;
        }
        
        public static object Robotics_Elk_Proxy_UpdateTaskRequest_TO_Robotics_Elk_UpdateTaskRequest(object transformFrom) {
            global::Robotics.Elk.UpdateTaskRequest target = new global::Robotics.Elk.UpdateTaskRequest();
            global::Robotics.Elk.Proxy.UpdateTaskRequest from = ((global::Robotics.Elk.Proxy.UpdateTaskRequest)(transformFrom));
            target.TaskId = from.TaskId;
            return target;
        }
        
        public static object Robotics_Elk_UpdateTaskRequest_TO_Robotics_Elk_Proxy_UpdateTaskRequest(object transformFrom) {
            global::Robotics.Elk.Proxy.UpdateTaskRequest target = new global::Robotics.Elk.Proxy.UpdateTaskRequest();
            global::Robotics.Elk.UpdateTaskRequest from = ((global::Robotics.Elk.UpdateTaskRequest)(transformFrom));
            target.TaskId = from.TaskId;
            return target;
        }
        
        private static global::Robotics.Elk.Proxy.StringName _cachedInstance0 = new global::Robotics.Elk.Proxy.StringName();
        
        private static global::Robotics.Elk.StringName _cachedInstance = new global::Robotics.Elk.StringName();
        
        public static object Robotics_Elk_Proxy_StringName_TO_Robotics_Elk_StringName(object transformFrom) {
            return _cachedInstance;
        }
        
        public static object Robotics_Elk_StringName_TO_Robotics_Elk_Proxy_StringName(object transformFrom) {
            return _cachedInstance0;
        }
    }
}
