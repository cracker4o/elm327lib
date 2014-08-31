using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class FuelPressureSendMessage : SendMessage
    {
        public FuelPressureSendMessage()
        {
            this.Command = "01";
            this.Data = "0A";
        }
    }
}
