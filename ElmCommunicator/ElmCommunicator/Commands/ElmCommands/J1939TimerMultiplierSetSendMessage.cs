using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class J1939TimerMultiplierSetSendMessage : SendMessage
    {
        public J1939TimerMultiplierSetSendMessage(int multiplier)
        {
            if(multiplier != 1 || multiplier != 5)
                throw new ArgumentOutOfRangeException("multiplier");

            this.Command = "AT JTM";
            this.Data = multiplier.ToString(CultureInfo.InvariantCulture);

        }
    }
}
