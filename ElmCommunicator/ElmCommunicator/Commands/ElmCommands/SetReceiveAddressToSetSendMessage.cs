using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class SetReceiveAddressToSetSendMessage : SendMessage
    {
        public SetReceiveAddressToSetSendMessage(string data)
        {
            if(this.CheckValidHexNumberByte(data))
                throw new ArgumentOutOfRangeException("data", "The data parameter is not a HEX number.");

            this.Command = "AT SR";
            this.Data = data;
        }
    }
}
