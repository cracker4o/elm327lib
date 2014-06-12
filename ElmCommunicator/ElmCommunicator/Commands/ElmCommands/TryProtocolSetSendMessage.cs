using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class TryProtocolSetSendMessage : SetProtocolSetSendMessage
    {
        public TryProtocolSetSendMessage(byte protocolId, bool reset = false) : base(protocolId, reset)
        {
            this.Command = "AT TP";
        }
    }
}
