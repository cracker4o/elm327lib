using ElmCommunicator.Responses.ElmResponses;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class AutoReceiveSendMessage : SendMessage
    {
        public AutoReceiveSendMessage()
        {
            this.ResponseMessage = new AutoReceiveResponseMessage();
            Command = "AT AR";
        }
    }
}