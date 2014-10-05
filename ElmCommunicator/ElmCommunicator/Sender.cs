using System;
using System.IO.Ports;
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

            _serialPort = serialPort;

            if (!_serialPort.IsOpen)
            {
                _serialPort.Open();
            }
        }

        public virtual void Send(ISendMessage message)
        {
            if (message == null)
            {
                throw new ArgumentNullException("message");
            }

            if (_serialPort.IsOpen)
            {
                MessageResponse = message.ResponseMessage;
                _serialPort.Write(message.ToString());
            }
        }

        public IReceiveMessage MessageResponse { get; set; }
    }
}