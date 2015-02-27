using ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicatorPortable.Commands.ObdIICommands.ShowCurrentData
{
    public class TimingAdvanceSendMessage : SendMessage
    {
        public TimingAdvanceSendMessage()
        {
            this.ResponseMessage = new TimingAdvanceResponse();
            Command = "01";
            Data = "0E";
        }
    }
}
