using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class MonitorAllMessagesSendMessage : SendMessage
    {
        public MonitorAllMessagesSendMessage()
        {
            this.Command = "AT MA";
        }
    }
}
