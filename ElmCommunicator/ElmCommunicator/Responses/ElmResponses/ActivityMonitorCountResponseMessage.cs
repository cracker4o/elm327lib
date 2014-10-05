using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ElmResponses
{
    public class ActivityMonitorCountResponseMessage : ResponseMessage
    {
        public ActivityMonitorCountResponseMessage()
        {
            Command = "AT AMC";
        }

        public override IReceiveMessage Parse(string message)
        {
            Data = message;

            return this;
        }
    }
}