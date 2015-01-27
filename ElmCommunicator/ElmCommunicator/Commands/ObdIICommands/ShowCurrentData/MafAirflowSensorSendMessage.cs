using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
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
