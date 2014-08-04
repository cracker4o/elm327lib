using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class CalculatedEngineLoadValueResponse : ResponseMessage
    {
        public override IReceiveMessage Parse(string message)
        {
            this.Command = this.GetCommand(ref message);
            this.Data = message.Substring(4);
            var bytes = this.StringToByteArray(this.Data);
            this.EngineLoadValue = bytes[0]*100/255;

            return this;
        }

        public int EngineLoadValue { get; set; }
    }
}
