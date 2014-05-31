using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class CanRxAddressSetSendMessage : CanRxAddressSendMessage
    {
        public CanRxAddressSetSendMessage(string address)
        {
            if (string.IsNullOrEmpty(address))
                throw new ArgumentNullException("address", "The address is empty.");

            if (address.Length != 3 && address.Length != 8)
                throw new ArgumentOutOfRangeException("address");

            this.Data = address;
        }
    }
}
