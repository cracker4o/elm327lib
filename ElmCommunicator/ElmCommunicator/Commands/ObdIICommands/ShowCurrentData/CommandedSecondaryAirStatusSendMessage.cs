using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
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
