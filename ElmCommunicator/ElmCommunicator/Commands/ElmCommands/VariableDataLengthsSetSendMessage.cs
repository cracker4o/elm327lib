using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class VariableDataLengthsSetSendMessage : SendMessage
    {
        public VariableDataLengthsSetSendMessage(bool state)
        {
            this.Command = "AT V";
            this.Data = Convert.ToInt32(state).ToString(CultureInfo.InvariantCulture);
        }
    }
}
