using ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicatorPortable.Commands.ObdIICommands.ShowCurrentData
{
    public class IntakeAirTemperatureSendMessage  : SendMessage
    {
        public IntakeAirTemperatureSendMessage()
        {
            this.Command = "01";
            this.Data = "0F";
            this.ResponseMessage = new IntakeAirTemperatureResponse();
        }
    }
}
