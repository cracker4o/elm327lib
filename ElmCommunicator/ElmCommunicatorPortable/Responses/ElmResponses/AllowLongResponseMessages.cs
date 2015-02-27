using System;
using ElmCommunicatorPortable.Commands;

namespace ElmCommunicatorPortable.Responses.ElmResponses
{
    public class AllowLongResponseMessages : ResponseMessage
    {
        public override IReceiveMessage Parse(string message)
        {
            throw new NotImplementedException();
        }
    }
}