using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class SupportedPidsSendMessage : SendMessage
    {
        public SupportedPidsSendMessage()
        {
            this.ResponseMessage = new SupportedPidsResponse();
            Command = "01";
            Data = "00";
        }
    }
}