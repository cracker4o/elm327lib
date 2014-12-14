namespace ElmCommunicator.Commands.ElmCommands
{
    public class CanStatusCountsSendMessage : SendMessage
    {
        public CanStatusCountsSendMessage()
        {
            Command = "AT CS";
        }
    }
}