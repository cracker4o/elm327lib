using ElmCommunicator.Responses;
using ElmCommunicator.Responses.ElmResponses;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class ResetAllSendMessage : SendMessage
    {
        public ResetAllSendMessage()
        {
            this.ResponseMessage = new CommonElmResponseMessage();
            Command = "AT Z";
        }
    }
}