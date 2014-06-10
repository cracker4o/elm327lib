using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class ProgramParameterSetSendMessage : SendMessage
    {
        public ProgramParameterSetSendMessage(string data, bool state)
        {
            if(string.IsNullOrEmpty(data))
                throw new ArgumentNullException("data");

            if(data.Length != 2 || !this.CheckValidHexNumberByte(data))
                throw new ArgumentOutOfRangeException("data");

            this.Command = "AT PP";
            this.Data = string.Format("{0} {1}", data, state ? "ON" : "OFF");
        }
    }
}
