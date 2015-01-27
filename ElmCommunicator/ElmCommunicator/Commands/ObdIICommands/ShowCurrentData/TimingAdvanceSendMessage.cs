using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class TimingAdvanceSendMessage : SendMessage
    {
        public TimingAdvanceSendMessage()
        {
            this.ResponseMessage = new TimingAdvanceResponse();
            Command = "01";
            Data = "0E";
        }
    }
}
