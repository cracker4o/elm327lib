using ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicatorPortable.Commands.ObdIICommands.ShowCurrentData
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