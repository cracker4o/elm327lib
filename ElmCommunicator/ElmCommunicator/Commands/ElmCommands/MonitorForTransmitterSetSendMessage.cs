using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class MonitorForTransmitterSetSendMessage : SendMessage
    {
        public MonitorForTransmitterSetSendMessage(string data)
        {
            if(data.Length != 2)
                throw new ArgumentOutOfRangeException("data");

            if(!this.CheckValidHexNumberByte(data))
                throw new ArgumentException("The data value is not a HEX number");

            this.Command = "AT MT";
            this.Data = data;
        }
    }
}
