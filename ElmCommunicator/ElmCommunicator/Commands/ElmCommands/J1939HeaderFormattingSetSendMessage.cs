using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class J1939HeaderFormattingSetSendMessage : SendMessage
    {
        public J1939HeaderFormattingSetSendMessage(bool state)
        {
            this.Command = "AT JHF";
            this.Data = Convert.ToInt32(state).ToString(CultureInfo.InvariantCulture);
        }
    }
}
