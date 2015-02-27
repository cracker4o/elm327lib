using ElmCommunicatorPortable.Responses.ElmResponses;

namespace ElmCommunicatorPortable.Commands.ElmCommands
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