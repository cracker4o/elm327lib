namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class ReadDataInUserMemorySendMessage : SendMessage
    {
        public ReadDataInUserMemorySendMessage()
        {
            Command = "AT RD";
        }
    }
}