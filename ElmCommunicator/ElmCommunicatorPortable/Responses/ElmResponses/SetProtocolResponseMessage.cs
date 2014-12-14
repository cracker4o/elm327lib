using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ElmResponses
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