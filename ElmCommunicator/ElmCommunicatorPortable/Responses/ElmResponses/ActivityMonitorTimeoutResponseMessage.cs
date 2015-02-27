using ElmCommunicatorPortable.Commands;

namespace ElmCommunicatorPortable.Responses.ElmResponses
{
    public class ActivityMonitorTimeoutResponseMessage : ResponseMessage
    {
        public ActivityMonitorTimeoutResponseMessage()
        {
            Command = "AT AMT";
        }

        public override IReceiveMessage Parse(string message)
        {
            Data = message;

            return this;
        }
    }
}