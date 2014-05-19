using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class AllowLongMessages : Message
    {
        public AllowLongMessages()
        {
            this.Command = "AT AL";
        }
    }
}
