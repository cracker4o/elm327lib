using ElmCommunicator.Responses.ElmResponses;

namespace ElmCommunicator.Commands.ElmCommands
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