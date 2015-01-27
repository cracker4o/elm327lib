using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class FreezeDtcSendMessage : SendMessage
    {
        public FreezeDtcSendMessage()
        {
            this.ResponseMessage = new FreezeDtcResponse();
            Command = "01";
            Data = "02";
        }
    }
}