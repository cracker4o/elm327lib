using ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicatorPortable.Commands.ObdIICommands.ShowCurrentData
{
    public class FuelPressureSendMessage : SendMessage
    {
        public FuelPressureSendMessage()
        {
            this.ResponseMessage = new FuelPressureResponse();
            Command = "01";
            Data = "0A";
        }
    }
}