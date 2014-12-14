namespace ElmCommunicator.Commands.ElmCommands
{
    public class AllowLongSendMessages : SendMessage
    {
        public AllowLongSendMessages()
        {
            Command = "AT AL";
        }
    }
}