using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class ReadDataInUserMemorySendMessage : SendMessage
    {
        public ReadDataInUserMemorySendMessage()
        {
            this.Command = "AT RD";
        }
    }
}
