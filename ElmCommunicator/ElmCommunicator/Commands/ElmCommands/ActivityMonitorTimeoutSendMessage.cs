using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class ActivityMonitorTimeoutSendMessage : SendMessage
    {
        public ActivityMonitorTimeoutSendMessage()
        {
            this.Command = "AT AMT";
        }

        public ActivityMonitorTimeoutSendMessage(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException("data", "The data is empty");
            }

            if (!this.CheckValidHexNumberByte(data))
            {
                throw new ArgumentOutOfRangeException("data", "The data is not a valid HEX number.");
            }

            this.Data = data;
        }
    }
}
