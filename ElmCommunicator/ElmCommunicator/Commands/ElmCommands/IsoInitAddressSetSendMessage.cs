using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class IsoInitAddressSetSendMessage : SendMessage
    {
        public IsoInitAddressSetSendMessage(string address)
        {
            if (!this.CheckValidHexNumberByte(address))
                throw new ArgumentException("Invalid argument - address");

            this.Command ="AT IIA";
            this.Data = address;
        }
    }
}
