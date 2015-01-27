using System;
using System.Globalization;
using ElmCommunicator.Responses.ElmResponses;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class BaudRateTimeoutSetSendMessage : SendMessage
    {
        public BaudRateTimeoutSetSendMessage(string dataValue)
        {
            this.ResponseMessage = new CommonElmResponseMessage();
            if (string.IsNullOrEmpty(dataValue))
                throw new ArgumentNullException("dataValue", "The baudrate dataValue is empty.");

            if (dataValue.Length != 2)
                throw new ArgumentOutOfRangeException("dataValue");

            int baudDivisor;
            if (!int.TryParse(dataValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out baudDivisor))
                throw new ArgumentException("NaN");

            Command = "AT BRT";
            Data = dataValue;
        }
    }
}