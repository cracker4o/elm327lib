using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class ForgetEventsSendMessage : SendMessage
    {
        public ForgetEventsSendMessage()
        {
            this.Command = "AT FE";
        }
    }
}
