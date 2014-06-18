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
            
            if (!this._serialPort.IsOpen)
            {
                this._serialPort.Open();
            }
        }

        public virtual void Send(ISendMessage message)
        {
            if (message == null)
            {
                throw new ArgumentNullException("message");
            }

            if (this._serialPort.IsOpen)
            {
                this.MessageResponse = message.ResponseMessage;
                this._serialPort.Write(message.ToString());
            }
        }

        public IReceiveMessage MessageResponse { get; set; }
    }
}
