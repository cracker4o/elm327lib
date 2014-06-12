using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class SetTimeoutSetSendMessage : SendMessage
    {
        public SetTimeoutSetSendMessage(string data)
        {
            if(!this.CheckValidHexNumberByte(data))
                throw new ArgumentOutOfRangeException("data", "The data is not a HEX number");

            this.Command = "AT ST";
            this.Data = data;
        }
    }
}
