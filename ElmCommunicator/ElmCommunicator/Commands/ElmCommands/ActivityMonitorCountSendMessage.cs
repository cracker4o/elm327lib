namespace ElmCommunicator.Commands.ElmCommands
{
    public class ActivityMonitorCountSendMessage : SendMessage
    {
        public ActivityMonitorCountSendMessage()
        {
            Command = "AT AMC";
        }
    }
}