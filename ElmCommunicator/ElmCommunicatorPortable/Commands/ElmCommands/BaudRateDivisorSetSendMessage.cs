using System;
using System.Globalization;
using ElmCommunicatorPortable.Responses.ElmResponses;

namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class BaudRateDivisorSetSendMessage : SendMessage
    {
        public BaudRateDivisorSetSendMessage(string dataValue)
        {
            this.ResponseMessage = new BaudRateDivisorResponseMessage();
            if (string.IsNullOrEmpty(dataValue))
                throw new ArgumentNullException("dataValue", "The baudrate divisor dataValue is empty.");

            if (dataValue.Length != 2)
                throw new ArgumentOutOfRangeException("dataValue");

            int baudDivisor;
            if (!int.TryParse(dataValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out baudDivisor))
                throw new ArgumentException("NaN");

            if (baudDivisor > 15 && baudDivisor < 0)
                throw new ArgumentOutOfRangeException("dataValue", "The dataValue is out of range.");

            Command = "AT BRD";
            Data = dataValue;
        }
    }
}