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
    public class SerialCommunicator : IDisposable
    {
        private SerialPort _port;
        private readonly SerialConfig _config;
        private ISender _sender;
        private readonly IReceiver _receiver;

        internal virtual void PortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var port = (SerialPort)sender;
            var message = this._receiver.Parse(port.ReadExisting(), this._sender.MessageResponse);

            if (message != null)
            {
                this._receiver.Process(message);
            }
        }

        public SerialCommunicator(SerialPort port = null)
        {
            this._config = SerialConfig.Default;

            if (port == null)
            {
                InitSerialPort();
            }
            else
            {
                this._port = port;
            }

            this._port.DataReceived += PortDataReceived;
            this._receiver = new Receiver();
            this._sender = new Sender(this._port);
        }

        private void InitSerialPort()
        {
            StopBits stopBits;
            Enum.TryParse(this._config.StopBits, out stopBits);
            Parity parity;
            Enum.TryParse(this._config.Parity, out parity);

            this._port = new SerialPort
            {
                BaudRate = this._config.BaudRate,
                DataBits = this._config.DataBits,
                PortName = this._config.PortName,
                StopBits = stopBits,
                Parity = parity
            };
        }

        public ISender Sender 
        {
            get
            {
                return this._sender;
            }
            set
            {
                this._sender = value;
            }
        }

        public IReceiver Receiver
        {
            get { return this._receiver; }
        }

        public void Dispose()
        {
            if(this._port.IsOpen)
                this._port.Close();

            this._port.Dispose();
        }
    }
}
