namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class SupportedPidsSendMessage : SendMessage
    {
        public SupportedPidsSendMessage()
        {
            Command = "01";
            Data = "00";
        }
    }
}