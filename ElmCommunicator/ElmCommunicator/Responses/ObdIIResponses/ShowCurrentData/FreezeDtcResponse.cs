using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class FreezeDtcResponse : ResponseMessage
    {
        public override IReceiveMessage Parse(string message)
        {
            message = message.Replace(" ", string.Empty);
            this.Command = message.Substring(0, 4);
            message = message.Substring(4);
            var bytes = this.StringToByteArray(message, false);
            this.ReceivedBytes = bytes;

            return this;
        }

        public byte[] ReceivedBytes { get; private set; }
    }
}
