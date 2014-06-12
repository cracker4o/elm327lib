using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class ResetAllSendMessage : SendMessage
    {
        public ResetAllSendMessage()
        {
            this.Command = "AT Z";
        }
    }
}
