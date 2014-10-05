using System;
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