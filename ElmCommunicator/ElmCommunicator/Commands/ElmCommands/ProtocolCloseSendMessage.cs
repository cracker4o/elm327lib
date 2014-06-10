using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class ProtocolCloseSendMessage : SendMessage
    {
        public ProtocolCloseSendMessage()
        {
            this.Command = "AT PC";
        }
    }
}
