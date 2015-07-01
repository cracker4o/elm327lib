using ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicatorPortable.Commands.ObdIICommands.ShowCurrentData
{
    public class ControlModuleVoltageSendMessage : SendMessage
    {
        public ControlModuleVoltageSendMessage()
        {
            this.Command = "01";
            this.Data = "42";
            this.ResponseMessage = new ControlModuleVoltageResponse();
        }
    }
}
