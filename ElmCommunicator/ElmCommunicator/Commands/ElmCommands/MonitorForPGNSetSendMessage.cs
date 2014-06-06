using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class MonitorForPgnSetSendMessage : SendMessage
    {
        public MonitorForPgnSetSendMessage(string data, int? times = null)
        {
            if(data.Length != 4 || data.Length != 6)
                throw new ArgumentOutOfRangeException("data");

            if (!this.CheckValidHexNumberByte(data))
                throw new ArgumentException("The data variable is not a HEX number.");

            this.Command = "AT MP";
            this.Data = data;
            if (times.HasValue)
            {
                this.Data = string.Concat(this.Data, times.ToString());
            }
        }
    }
}
