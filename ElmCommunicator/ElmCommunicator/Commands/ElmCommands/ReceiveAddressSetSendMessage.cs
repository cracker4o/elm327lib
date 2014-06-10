using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class ReceiveAddressSetSendMessage : SendMessage
    {
        public ReceiveAddressSetSendMessage(string data)
        {
            if(string.IsNullOrEmpty(data))
                throw new ArgumentNullException("data");

            if(!this.CheckValidHexNumberByte(data))
                throw new ArgumentOutOfRangeException("data");

            this.Command = "AT RA";
            this.Data = data;
        }
    }
}
