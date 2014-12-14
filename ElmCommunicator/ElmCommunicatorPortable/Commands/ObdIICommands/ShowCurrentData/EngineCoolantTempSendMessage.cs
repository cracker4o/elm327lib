namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class EngineCoolantTempSendMessage : SendMessage
    {
        public EngineCoolantTempSendMessage()
        {
            Command = "01";
            Data = "05";
        }
    }
}