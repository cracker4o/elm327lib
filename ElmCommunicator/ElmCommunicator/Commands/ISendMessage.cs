using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands
{
    public interface ISendMessage : ICommunicationMessage
    {
        IReceiveMessage ResponseMessage { get; set; }
    }
}
