using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElmCommunicator.Commands
{
    public interface ICommunicationMessage
    {
        string Command { get; set; }
        string Data { get; set; }

        string StartTermination { get; set; }

        string EndTermination { get; set; }
    }
}
