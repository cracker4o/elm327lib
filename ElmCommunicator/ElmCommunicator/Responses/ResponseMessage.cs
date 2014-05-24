using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses
{
    public abstract class ResponseMessage : IReceiveMessage
    {
        public string Command { get; set; }
        public string Data { get; set; }
        public string StartTermination { get; set; }
        public string EndTermination { get; set; }
        public abstract IReceiveMessage Parse(string message);
    }
}
