using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class MonitorDm1SendMessage : SendMessage
    {
        public MonitorDm1SendMessage()
        {
            this.Command = "AT DM1";
        }
    }
}
