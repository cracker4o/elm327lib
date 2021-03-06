﻿// Copyright 2015 Tosho Toshev
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
using System;
using System.IO.Ports;
using System.Linq;
using ElmCommunicator.Commands;
using ElmCommunicator.Configurations;

namespace ElmCommunicator
{
    public class SerialCommunicator : IDisposable
    {
        private readonly SerialConfig _config;
        private readonly IReceiver _receiver;
        private SerialPort _port;
        private ISender _sender;

        public SerialCommunicator(SerialPort port = null)
        {
            _config = SerialConfig.Default;

            if (port == null)
            {
                InitSerialPort();
            }
            else
            {
                _port = port;
            }

            _port.DataReceived += PortDataReceived;
            _receiver = new Receiver();
            _sender = new Sender(_port);
        }

        public ISender Sender
        {
            get { return _sender; }
            set { _sender = value; }
        }

        public IReceiver Receiver
        {
            get { return _receiver; }
        }

        public void Dispose()
        {
            if (_port.IsOpen)
                _port.Close();

            _port.Dispose();
        }

        internal virtual void PortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var port = (SerialPort) sender;
            string received = port.ReadExisting();
            received = received.Replace("\r\n\r\n", "|");
            string[] dataStrings = received.Split('|');
            IReceiveMessage message;

            if(dataStrings.Count() > 1)
            {
                message = _receiver.Parse(dataStrings[1].Replace("\r\n>", string.Empty), _sender.MessageResponse);
            }
            else
            {
                message = _receiver.Parse(received.Replace("\r\n", string.Empty).Replace(">", string.Empty),
                    _sender.MessageResponse);
            }

            if (message != null)
            {
                _receiver.Process(message);
            }
        }

        private void InitSerialPort()
        {
            StopBits stopBits;
            Enum.TryParse(_config.StopBits, out stopBits);
            Parity parity;
            Enum.TryParse(_config.Parity, out parity);

            _port = new SerialPort
            {
                BaudRate = _config.BaudRate,
                DataBits = _config.DataBits,
                PortName = _config.PortName,
                StopBits = stopBits,
                Parity = parity
            };
        }
    }
}