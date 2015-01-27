using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class EngineCoolantTempSendMessage : SendMessage
    {
        public EngineCoolantTempSendMessage()
        {
            this.ResponseMessage = new EngineCoolantTemperatureResponse();
            Command = "01";
            Data = "05";
        }
    }
}