using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;

namespace ElmCommunicator
{
    public class Receiver : IReceiver
    {
        public delegate void ProcessMessage(ICommunicationMessage message);

        public ProcessMessage OnProcessMessage { get; set; }

        public ICommunicationMessage Parse(string received)
        {
            ICommunicationMessage message  = null;

            

            return message;
        }

        public void Process(ICommunicationMessage message)
        {
            if (this.OnProcessMessage != null)
            {
                this.OnProcessMessage(message);
            }
        }
    }
}
