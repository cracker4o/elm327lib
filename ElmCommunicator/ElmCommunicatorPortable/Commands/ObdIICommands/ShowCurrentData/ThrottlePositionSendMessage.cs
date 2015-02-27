using ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicatorPortable.Commands.ObdIICommands.ShowCurrentData
{
    public class ThrottlePositionSendMessage : SendMessage
    {
        public ThrottlePositionSendMessage()
        {
            this.ResponseMessage = new ThrottlePositionResponse();
            Command = "01";
            Data = "11";
        }
    }
}
