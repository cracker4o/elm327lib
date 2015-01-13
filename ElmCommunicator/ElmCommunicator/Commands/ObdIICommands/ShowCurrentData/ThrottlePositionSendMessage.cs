using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class ThrottlePositionSendMessage : SendMessage
    {
        public ThrottlePositionSendMessage()
        {
            Command = "01";
            Data = "11";
        }
    }
}
