using ElmCommunicatorPortable.Responses.ElmResponses;

namespace ElmCommunicatorPortable.Commands.ElmCommands
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