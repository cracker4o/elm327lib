using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class EnableJ1939ElmDataFormatSendMessage : SendMessage
    {
        public EnableJ1939ElmDataFormatSendMessage()
        {
            this.Command = "AT JE";
        }
    }
}
