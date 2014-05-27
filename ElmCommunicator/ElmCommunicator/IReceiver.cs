using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;

namespace ElmCommunicator
{
    /// <summary>
    /// A delegate for message processing.
    /// </summary>
    /// <param name="message"></param>
    public delegate void ProcessMessage(ICommunicationMessage message);

    public interface IReceiver
    {
        IReceiveMessage Parse(string received, IReceiveMessage msgTemplate);

        void Process(IReceiveMessage message);

        ProcessMessage OnProcessMessage { get; set; }
    }
}
