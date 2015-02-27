using ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicatorPortable.Commands.ObdIICommands.ShowCurrentData
{
    public class MonitorStatusSinceDtcSendMessage : SendMessage
    {
        public MonitorStatusSinceDtcSendMessage()
        {
            this.ResponseMessage = new MonitorStatusSinceDtcClearedResponse();
            Command = "01";
            Data = "01";
        }
    }
}