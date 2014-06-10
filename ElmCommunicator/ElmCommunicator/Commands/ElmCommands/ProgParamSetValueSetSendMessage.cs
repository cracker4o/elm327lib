using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class ProgParamSetValueSetSendMessage : SendMessage
    {
        public ProgParamSetValueSetSendMessage(string data, string value)
        {
            if (string.IsNullOrEmpty(data))
                throw new ArgumentNullException("data");

            if (data.Length != 2 || !this.CheckValidHexNumberByte(data))
                throw new ArgumentOutOfRangeException("data");

            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException("value");

            this.Command = "AT PP";
            this.Data = string.Format("{0} SV {1}", data, value);
        }
    }
}
