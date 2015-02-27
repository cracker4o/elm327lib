using ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicatorPortable.Commands.ObdIICommands.ShowCurrentData
{
    public class MafAirflowSensorSendMessage : SendMessage
    {
        public MafAirflowSensorSendMessage()
        {
            this.ResponseMessage = new MafAirflowSensorResponse();
            this.Command = "01";
            this.Data = "10";
        }
    }
}
