using ElmCommunicatorPortable.Commands;

namespace ElmCommunicatorPortable.Responses.ElmResponses
{
    public class SetProtocolResponseMessage : ResponseMessage
    {
        public SetProtocolResponseMessage()
        {
            Command = "AT SP";
        }

        public override IReceiveMessage Parse(string message)
        {
            Data = message;
            return this;
        }
    }
}