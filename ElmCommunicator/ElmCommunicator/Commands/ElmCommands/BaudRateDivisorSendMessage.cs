using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class BaudRateDivisorSendMessage : SendMessage
    {
        public BaudRateDivisorSendMessage()
        {
            this.Command = "AT BRD";
        }

        public BaudRateDivisorSendMessage(string data)
            : this()
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
