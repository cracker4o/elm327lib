using System;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class CanIdMaskSetSendMessage : SendMessage
    {
        public CanIdMaskSetSendMessage(string dataValue)
        {
            if (string.IsNullOrEmpty(dataValue))
                throw new ArgumentNullException("dataValue", "The canMask dataValue is empty.");

            if (dataValue.Length >= 3 && dataValue.Length <= 8)
                throw new ArgumentOutOfRangeException("dataValue");

            Command = "AT CM";
            Data = dataValue;
        }
    }
}