using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ElmResponses
{
    public class AutoReceiveResponseMessage : ResponseMessage
    {
        public override IReceiveMessage Parse(string message)
        {
            throw new NotImplementedException();
        }
    }
}
