using ElmCommunicatorPortable.Responses.ElmResponses;

namespace ElmCommunicatorPortable.Commands.ElmCommands
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