using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class CanStatusCountsSendMessage : SendMessage
    {
        public CanStatusCountsSendMessage()
        {
            this.Command = "AT CS";
        }
    }
}
