using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class HeadersOnOffSetSendMEssage : SendMessage
    {
        public HeadersOnOffSetSendMEssage(bool state)
        {
            this.Command = "AT H";
            this.Data = Convert.ToInt32(state).ToString(CultureInfo.InvariantCulture);
        }
    }
}
