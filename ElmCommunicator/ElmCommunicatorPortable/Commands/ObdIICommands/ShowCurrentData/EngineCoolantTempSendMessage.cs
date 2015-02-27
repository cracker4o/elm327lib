using ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicatorPortable.Commands.ObdIICommands.ShowCurrentData
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