namespace ElmCommunicator.Commands.ElmCommands
{
    public class BypassInitializationSendMessage : SendMessage
    {
        public BypassInitializationSendMessage()
        {
            Command = "AT BI";
        }
    }
}