using ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicatorPortable.Commands.ObdIICommands.ShowCurrentData
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