using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class SetProtocolToAutoSendMessage : SendMessage
    {
        public SetProtocolToAutoSendMessage(byte protocolId)
        {
            this.Command = "AT SP A";
            this.Data = string.Format("{0}", protocolId.ToString("X").Last());

        }
    }
}
