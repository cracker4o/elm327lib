using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Configurations
{
    /// <summary>
    /// Serial port settings
    /// </summary>
    [SettingsSerializeAs(SettingsSerializeAs.Xml)]
    public class SerialConfig : ApplicationSettingsBase, ICommunicationConfig
    {
        [UserScopedSetting()]    
        [DefaultSettingValue("38400")]
        public int BaudRate { get; set; }

        [UserScopedSetting()]
        [DefaultSettingValue("8")]
        public int DataBits { get; set; }

        [UserScopedSetting()]
        [DefaultSettingValue("1")]
        public string StopBits { get; set; }

        [UserScopedSetting()]
        [DefaultSettingValue("None")]
        public string Parity { get; set; }

        [UserScopedSetting()]
        [DefaultSettingValue("COM1")]
        public string PortName { get; set; }
    }
}
