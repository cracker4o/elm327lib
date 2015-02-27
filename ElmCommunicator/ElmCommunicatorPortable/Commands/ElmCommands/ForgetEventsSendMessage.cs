using ElmCommunicatorPortable.Responses.ElmResponses;

namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class ForgetEventsSendMessage : SendMessage
    {
        public ForgetEventsSendMessage()
        {
            this.ResponseMessage = new CommonElmResponseMessage();
            Command = "AT FE";
        }
    }
}