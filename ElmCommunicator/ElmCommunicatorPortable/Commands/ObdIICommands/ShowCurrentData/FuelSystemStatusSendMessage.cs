using ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicatorPortable.Commands.ObdIICommands.ShowCurrentData
{
    public class FuelSystemStatusSendMessage : SendMessage
    {
        public FuelSystemStatusSendMessage()
        {
            this.ResponseMessage = new FuelSystemStatusResponse();
            Command = "01";
            Data = "03";
        }
    }
}