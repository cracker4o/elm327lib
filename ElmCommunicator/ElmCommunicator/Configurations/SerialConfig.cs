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