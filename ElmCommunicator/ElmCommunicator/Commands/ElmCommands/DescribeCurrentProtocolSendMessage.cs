using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class DescribeCurrentProtocolSendMessage : SendMessage
    {
        public DescribeCurrentProtocolSendMessage(bool byNumber = false)
        {
            this.Command = byNumber ? "AT DPN" : "AT DP";
        }
    }
}
