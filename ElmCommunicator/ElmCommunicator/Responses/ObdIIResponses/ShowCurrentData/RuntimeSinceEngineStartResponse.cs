using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class RuntimeSinceEngineStartResponse : ResponseMessage
    {
        public override IReceiveMessage Parse(string message)
        {
            this.Command = this.GetCommand(ref message);
            this.Data = message.Substring(4);
            var responseBytes = this.StringToByteArray(this.Data, false);
            this.EngineTime = (responseBytes[0] * 256) + responseBytes[1];

            return this;
        }

        public int EngineTime { get; set; } 
    }
}
