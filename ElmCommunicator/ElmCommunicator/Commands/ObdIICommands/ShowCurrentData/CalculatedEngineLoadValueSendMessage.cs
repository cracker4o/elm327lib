namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class CalculatedEngineLoadValueSendMessage : SendMessage
    {
        public CalculatedEngineLoadValueSendMessage()
        {
            Command = "01";
            Data = "04";
        }
    }
}