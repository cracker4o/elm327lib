using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class EngineCoolantTempSendMessage : SendMessage
    {
        public EngineCoolantTempSendMessage()
        {
            this.Command = "01";
            this.Data = "05";
        }
    }
}
