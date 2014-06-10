using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class PrintSpacesOnOffSetSendMessage : SendMessage
    {
        public PrintSpacesOnOffSetSendMessage(bool state)
        {
            this.Command = "AT S";
            this.Data = Convert.ToInt32(state).ToString(CultureInfo.InvariantCulture);
        }
    }
}
