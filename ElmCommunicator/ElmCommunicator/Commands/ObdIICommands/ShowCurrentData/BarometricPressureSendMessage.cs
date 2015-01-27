using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class BarometricPressureSendMessage : SendMessage
    {
        public BarometricPressureSendMessage()
        {
            this.ResponseMessage = new BarometricPressureResponse();
            this.Command = "01";
            this.Data = "33";
        }
    }
}
