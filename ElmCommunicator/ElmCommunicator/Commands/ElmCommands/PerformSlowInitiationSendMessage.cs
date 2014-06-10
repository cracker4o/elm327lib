using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class PerformSlowInitiationSendMessage : SendMessage
    {
        public PerformSlowInitiationSendMessage()
        {
            this.Command = "AT SI";
        }
    }
}
