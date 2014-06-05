using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class EnableJ1939SaeDataFormatSendMessage : SendMessage
    {
        public EnableJ1939SaeDataFormatSendMessage()
        {
            this.Command = "AT JS";
        }
    }
}
