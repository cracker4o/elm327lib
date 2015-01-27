using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class CalculatedEngineLoadValueSendMessage : SendMessage
    {
        public CalculatedEngineLoadValueSendMessage()
        {
            this.ResponseMessage = new CalculatedEngineLoadValueResponse();
            Command = "01";
            Data = "04";
        }
    }
}