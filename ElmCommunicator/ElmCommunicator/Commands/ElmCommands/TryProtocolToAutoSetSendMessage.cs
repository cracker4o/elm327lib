using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class TryProtocolToAutoSetSendMessage : SetProtocolToAutoSendMessage
    {
        public TryProtocolToAutoSetSendMessage(byte protocolId) : base(protocolId)
        {
            this.Command = "AT TP A";
        }
    }
}
