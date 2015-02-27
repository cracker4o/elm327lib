namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class ProtocolCloseSendMessage : SendMessage
    {
        public ProtocolCloseSendMessage()
        {
            Command = "AT PC";
        }
    }
}