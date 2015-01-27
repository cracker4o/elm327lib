using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
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