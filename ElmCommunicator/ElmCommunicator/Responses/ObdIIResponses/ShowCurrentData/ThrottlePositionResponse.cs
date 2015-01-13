using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class ThrottlePositionResponse : ResponseMessage
    {
        public int ThrottlePosition { get; set; } 

        public override IReceiveMessage Parse(string message)
        {
            Command = GetCommand(ref message);
            Data = message.Substring(4);
            this.ThrottlePosition = HexToDec(Data) * 100/255;
            return this;
        }
    }
}
