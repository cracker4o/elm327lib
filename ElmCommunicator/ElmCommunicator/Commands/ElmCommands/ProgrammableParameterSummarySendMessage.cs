using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class ProgrammableParameterSummarySendMessage : SendMessage
    {
        public ProgrammableParameterSummarySendMessage()
        {
            this.Command = "AT PPS";
        }
    }
}
