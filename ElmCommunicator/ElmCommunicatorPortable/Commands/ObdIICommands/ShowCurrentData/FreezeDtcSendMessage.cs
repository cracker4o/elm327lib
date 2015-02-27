using ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicatorPortable.Commands.ObdIICommands.ShowCurrentData
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