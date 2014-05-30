using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class CanFlowControlSetSendMessage : SendMessage
    {
        public CanFlowControlSetSendMessage(bool state)
        {
            this.Command = "AT CFC";
            this.Data = Convert.ToInt32(state).ToString(CultureInfo.InvariantCulture);
        }
    }
}
