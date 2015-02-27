// Copyright 2015 Tosho Toshev
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
using System.Configuration;

namespace ElmCommunicator.Configurations
{
    /// <summary>
    ///     Serial port settings
    /// </summary>
    public class SerialConfig : ApplicationSettingsBase, ICommunicationConfig
    {
        private static readonly SerialConfig DefaultInstance = ((SerialConfig) (Synchronized(new SerialConfig())));

        public static SerialConfig Default
        {
            get { return DefaultInstance; }
        }

        [UserScopedSetting]
        [DefaultSettingValue("38400")]
        public int BaudRate
        {
            get { return (int) this["BaudRate"]; }
            set { this["BaudRate"] = value; }
        }

        [UserScopedSetting]
        [DefaultSettingValue("8")]
        public int DataBits
        {
            get { return (int) this["DataBits"]; }
            set { this["DataBits"] = value; }
        }

        [UserScopedSetting]
        [DefaultSettingValue("1")]
        public string StopBits
        {
            get { return (string) this["StopBits"]; }
            set { this["StopBits"] = value; }
        }

        [UserScopedSetting]
        [DefaultSettingValue("None")]
        public string Parity
        {
            get { return (string) this["Parity"]; }
            set { this["Parity"] = value; }
        }

        [UserScopedSetting]
        [DefaultSettingValue("COM1")]
        public string PortName
        {
            get { return (string) this["PortName"]; }
            set { this["PortName"] = value; }
        }
    }
}