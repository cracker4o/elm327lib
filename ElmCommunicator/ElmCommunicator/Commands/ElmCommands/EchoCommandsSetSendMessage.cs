using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class EchoCommandsSetSendMessage : SendMessage
    {
        public EchoCommandsSetSendMessage(bool state)
        {
            this.Command = "E";
            this.Data = Convert.ToInt32(state).ToString(CultureInfo.InvariantCulture);
        }
    }
}
