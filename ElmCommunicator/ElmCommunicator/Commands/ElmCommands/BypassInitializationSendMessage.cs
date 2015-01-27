using ElmCommunicator.Responses.ElmResponses;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class BypassInitializationSendMessage : SendMessage
    {
        public BypassInitializationSendMessage()
        {
            this.ResponseMessage = new CommonElmResponseMessage();
            Command = "AT BI";
        }
    }
}