using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class CalculatedEngineLoadValueSendMessage : SendMessage
    {
        public CalculatedEngineLoadValueSendMessage()
        {
            this.Command = "01";
            this.Data = "04";
        }
    }
}
