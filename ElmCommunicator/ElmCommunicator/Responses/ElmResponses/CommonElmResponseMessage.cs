using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ElmResponses
{
    public class CommonElmResponseMessage : ResponseMessage
    {
        public override IReceiveMessage Parse(string message)
        {
            this.GetCommand(ref message);
            this.Data = message.Substring(4);
            return this;
        }
    }
}
