using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Configurations;

namespace ElmCommunicator
{
    public class SerialCommunicator
    {
        private readonly SerialPort _port;
        private readonly SerialConfig _config;
        private ISender _sender;

        private void PortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var port = (SerialPort)sender;
            var receiver = new Receiver();
            var message = receiver.Parse(port.ReadExisting());

            if (message != null)
            {
                receiver.Process(message);
            }
        }

        public SerialCommunicator()
        {
            StopBits stopBits;
            Enum.TryParse(this._config.StopBits, out stopBits);
            Parity parity;
            Enum.TryParse(this._config.Parity, out parity);

            this._config = (SerialConfig)SettingsBase.Synchronized(new SerialConfig());
            this._port = new SerialPort
            {
                BaudRate = this._config.BaudRate,
                DataBits = this._config.DataBits,
                PortName = this._config.PortName,
                StopBits = stopBits,
                Parity = parity
            };

            this._port.DataReceived += PortDataReceived;
        }

        public ISender Sender 
        {
            get 
            {
                if (this._sender == null)
                {
                    return new Sender(this._port);
                }

                return this._sender;
            }
            set
            {
                this._sender = value;
            }
        }
    }
}
