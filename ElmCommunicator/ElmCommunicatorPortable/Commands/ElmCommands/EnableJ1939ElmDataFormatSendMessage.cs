namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class EnableJ1939ElmDataFormatSendMessage : SendMessage
    {
        public EnableJ1939ElmDataFormatSendMessage()
        {
            Command = "AT JE";
        }
    }
}