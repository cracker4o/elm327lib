using ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicatorPortable.Commands.ObdIICommands.ShowCurrentData
{
    public class IntakeManifoldPressureSendMessage : SendMessage
    {
        public IntakeManifoldPressureSendMessage()
        {
            this.ResponseMessage = new IntakeManifoldPressureResponse();
            Command = "01";
            Data = "0B";
        }
    }
}