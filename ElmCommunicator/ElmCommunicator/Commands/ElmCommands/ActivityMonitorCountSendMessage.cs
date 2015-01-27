using ElmCommunicator.Responses.ElmResponses;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class ActivityMonitorCountSendMessage : SendMessage
    {
        public ActivityMonitorCountSendMessage()
        {
            this.ResponseMessage = new ActivityMonitorCountResponseMessage();
            Command = "AT AMC";
        }
    }
}