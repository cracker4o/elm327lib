using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class SetAllToDefaultsSetSendMessage : SendMessage
    {
        public SetAllToDefaultsSetSendMessage()
        {
            this.Command = "AT D";
        }

        public SetAllToDefaultsSetSendMessage(bool dlcDigitState)
            : this()
        {
            this.Data = Convert.ToInt32(dlcDigitState).ToString(CultureInfo.InvariantCulture);
        }
    }
}
