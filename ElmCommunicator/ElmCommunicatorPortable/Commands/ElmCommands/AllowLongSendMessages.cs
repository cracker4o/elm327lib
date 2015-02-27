using ElmCommunicatorPortable.Responses.ElmResponses;

namespace ElmCommunicatorPortable.Commands.ElmCommands
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