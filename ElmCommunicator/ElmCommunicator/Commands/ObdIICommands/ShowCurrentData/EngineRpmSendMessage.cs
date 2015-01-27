using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class EngineRpmSendMessage : SendMessage
    {
        public EngineRpmSendMessage()
        {
            this.ResponseMessage = new EngineRpmResponse();
            Command = "01";
            Data = "0C";
        }
    }
}