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
        public ICommunicationMessage Parse(string received)
        {
            throw new NotImplementedException();
        }

        public void Process(ICommunicationMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
