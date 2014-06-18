using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ElmResponses
{
    public class SetProtocolResponseMessage : ResponseMessage
    {
        public SetProtocolResponseMessage()
        {
            this.Command = "AT SP";
        }

        public override IReceiveMessage Parse(string message)
        {
            this.Data = message;
        }
    }
}
