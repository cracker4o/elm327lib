using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;

namespace ElmCommunicator
{
    public class Sender : ISender
    {
        private readonly SerialPort _serialPort;
        public Sender(SerialPort serialPort)
        {
            if (serialPort == null)
            {
                throw new ArgumentNullException("serialPort");
            }

            this._serialPort = serialPort;
        }

        public void Send(ISendMessage message)
        {
            if (this._serialPort.IsOpen)
            {
                this._serialPort.Write(message.ToString());
            }
        }
    }
}
