using ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicatorPortable.Commands.ObdIICommands.ShowCurrentData
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