using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class CanExtendedMessageSetSendMessage : CanExtendedAddressSendMessage
    {
        public CanExtendedMessageSetSendMessage(string dataValue)
            : base()
        {
            if (string.IsNullOrEmpty(dataValue))
                throw new ArgumentNullException("dataValue", "The can CanExtendedMessage dataValue is empty.");

            if (dataValue.Length != 2)
                throw new ArgumentOutOfRangeException("dataValue");

            this.Data = dataValue;
        }
    }
}
