namespace ElmCommunicator.Commands.ElmCommands
{
    public class ReadDataInUserMemorySendMessage : SendMessage
    {
        public ReadDataInUserMemorySendMessage()
        {
            Command = "AT RD";
        }
    }
}