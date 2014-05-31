using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class IdentifyYourselfSendMessage : SendMessage
    {
        public IdentifyYourselfSendMessage()
        {
            this.Command = "AT I";
        }
    }
}
