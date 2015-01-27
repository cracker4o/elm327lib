using ElmCommunicator.Responses.ElmResponses;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class AllowLongSendMessages : SendMessage
    {
        public AllowLongSendMessages()
        {
            this.ResponseMessage = new AllowLongResponseMessages();
            Command = "AT AL";
        }
    }
}