using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class CanIdFilterSetSendMessage : SendMessage
    {
        public CanIdFilterSetSendMessage(string dataValue)
        {
            this.Command = "AT CF";

            if (string.IsNullOrEmpty(dataValue))
                throw new ArgumentNullException("dataValue", "The cand filter message dataValue is empty.");

            if (dataValue.Length != 2)
                throw new ArgumentOutOfRangeException("dataValue");

            this.Data = dataValue;

        }
    }
}
