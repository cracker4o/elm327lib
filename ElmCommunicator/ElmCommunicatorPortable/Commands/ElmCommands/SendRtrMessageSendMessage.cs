namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class SendRtrMessageSendMessage : SendMessage
    {
        public SendRtrMessageSendMessage()
        {
            Command = "AT RTR";
        }
    }
}