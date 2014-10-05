namespace ElmCommunicator.Commands.ElmCommands
{
    public class AutoReceiveSendMessage : SendMessage
    {
        public AutoReceiveSendMessage()
        {
            Command = "AT AR";
        }
    }
}