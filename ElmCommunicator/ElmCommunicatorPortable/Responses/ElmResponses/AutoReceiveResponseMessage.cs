using System;
using ElmCommunicatorPortable.Commands;

namespace ElmCommunicatorPortable.Responses.ElmResponses
{
    public class AutoReceiveResponseMessage : ResponseMessage
    {
        public override IReceiveMessage Parse(string message)
        {
            throw new NotImplementedException();
        }
    }
}