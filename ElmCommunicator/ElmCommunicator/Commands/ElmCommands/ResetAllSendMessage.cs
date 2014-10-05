namespace ElmCommunicator.Commands.ElmCommands
{
    public class ResetAllSendMessage : SendMessage
    {
        public ResetAllSendMessage()
        {
            Command = "AT Z";
        }
    }
}