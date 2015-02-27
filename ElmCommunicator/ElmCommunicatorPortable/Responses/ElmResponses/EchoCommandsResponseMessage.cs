using ElmCommunicatorPortable.Commands;

namespace ElmCommunicatorPortable.Responses.ElmResponses
{
    public class EchoCommandsResponseMessage : ResponseMessage
    {
        public EchoCommandsResponseMessage()
        {
            Command = "AT E";
        }

        public override IReceiveMessage Parse(string message)
        {
            Data = message;
            return this;
        }
    }
}