namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class EnableJ1939SaeDataFormatSendMessage : SendMessage
    {
        public EnableJ1939SaeDataFormatSendMessage()
        {
            Command = "AT JS";
        }
    }
}