using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class MonitorReceiverAddressSetSendMessage : SendMessage
    {
        public MonitorReceiverAddressSetSendMessage(string data)
        {
            if (this.Data.Length != 2)
                throw new ArgumentOutOfRangeException("data");

            if (this.CheckValidHexNumberByte(data))
                throw new ArgumentException("The data is not a hex number");

            this.Command = "AT MR";
            this.Data = data;
        }
    }
}
