using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class SetProtocolBParametersSetSendMessage : SendMessage
    {
        public SetProtocolBParametersSetSendMessage(string xx, string yy)
        {
            if (xx.Length != 2)
                throw new ArgumentOutOfRangeException("xx");

            if (yy.Length != 2)
                throw new ArgumentOutOfRangeException("yy");

            if (!this.CheckValidHexNumberByte(xx) || !this.CheckValidHexNumberByte(yy))
                throw new ArgumentException("The arguments are not HEX numbers");

            this.Command = "AT PB";
            this.Data = string.Format("{0} {1}", xx, yy);
        }
    }
}
