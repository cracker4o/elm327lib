using System;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class CanExtendedMessageSetSendMessage : CanExtendedAddressSendMessage
    {
        public CanExtendedMessageSetSendMessage(string dataValue)
        {
            if (string.IsNullOrEmpty(dataValue))
                throw new ArgumentNullException("dataValue", "The can CanExtendedMessage dataValue is empty.");

            if (dataValue.Length != 2)
                throw new ArgumentOutOfRangeException("dataValue");

            Data = dataValue;
        }
    }
}