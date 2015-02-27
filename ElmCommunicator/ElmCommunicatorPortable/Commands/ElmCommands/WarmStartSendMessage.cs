namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class WarmStartSendMessage : SendMessage
    {
        public WarmStartSendMessage()
        {
            Command = "AT WS";
        }
    }
}