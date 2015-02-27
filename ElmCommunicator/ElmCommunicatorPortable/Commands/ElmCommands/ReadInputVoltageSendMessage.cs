namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class ReadInputVoltageSendMessage : SendMessage
    {
        public ReadInputVoltageSendMessage()
        {
            Command = "AT RV";
        }
    }
}