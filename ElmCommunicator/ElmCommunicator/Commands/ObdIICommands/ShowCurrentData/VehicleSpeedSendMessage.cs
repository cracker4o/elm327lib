using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class VehicleSpeedSendMessage : SendMessage
    {
        public VehicleSpeedSendMessage()
        {
            this.ResponseMessage = new VehicleSpeedResponse();
            Command = "01";
            Data = "0D";
        }
    }
}