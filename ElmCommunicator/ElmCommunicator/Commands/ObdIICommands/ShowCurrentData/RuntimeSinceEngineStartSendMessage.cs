using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class RuntimeSinceEngineStartSendMessage : SendMessage
    {
        public RuntimeSinceEngineStartSendMessage()
        {
            this.Command = "01";
            this.Data = "1F";
            this.ResponseMessage = new RuntimeSinceEngineStartResponse();
        }
    }
}
