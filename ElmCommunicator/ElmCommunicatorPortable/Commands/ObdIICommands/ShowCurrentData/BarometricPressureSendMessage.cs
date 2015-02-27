using ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicatorPortable.Commands.ObdIICommands.ShowCurrentData
{
    public class BarometricPressureSendMessage : SendMessage
    {
        public BarometricPressureSendMessage()
        {
            this.ResponseMessage = new BarometricPressureResponse();
            this.Command = "01";
            this.Data = "33";
        }
    }
}
