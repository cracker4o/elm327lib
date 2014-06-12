using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class WarmStartSendMessage : SendMessage
    {
        public WarmStartSendMessage()
        {
            this.Command = "AT WS";
        }
    }
}
