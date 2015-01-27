using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
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
