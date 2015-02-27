using ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicatorPortable.Commands.ObdIICommands.ShowCurrentData
{
    public class CommandedSecondaryAirStatusSendMessage : SendMessage
    {
        public CommandedSecondaryAirStatusSendMessage()
        {
            this.ResponseMessage = new CommandedSecondaryAirStatusResponse();
            Command = "01";
            Data = "12";
        }
    }
}
