using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class FuelLevelSendMessage : SendMessage
    {
        public FuelLevelSendMessage()
        {
            this.Command = "01";
            this.Data = "2F";
        }
    }
}
