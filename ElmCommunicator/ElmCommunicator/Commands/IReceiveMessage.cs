using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands
{
    public interface IReceiveMessage : ICommunicationMessage
    {
        IReceiveMessage Parse(string message);
    }
}
