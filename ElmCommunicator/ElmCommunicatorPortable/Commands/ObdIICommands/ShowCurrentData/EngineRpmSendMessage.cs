namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class EngineRpmSendMessage : SendMessage
    {
        public EngineRpmSendMessage()
        {
            Command = "01";
            Data = "0C";
        }
    }
}