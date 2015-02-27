namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class IdentifyYourselfSendMessage : SendMessage
    {
        public IdentifyYourselfSendMessage()
        {
            Command = "AT I";
        }
    }
}