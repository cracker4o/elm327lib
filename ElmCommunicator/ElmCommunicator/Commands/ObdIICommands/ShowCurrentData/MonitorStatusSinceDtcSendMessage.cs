namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class MonitorStatusSinceDtcSendMessage : SendMessage
    {
        public MonitorStatusSinceDtcSendMessage()
        {
            Command = "01";
            Data = "01";
        }
    }
}