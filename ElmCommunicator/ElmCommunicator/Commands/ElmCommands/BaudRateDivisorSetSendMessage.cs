using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class BaudRateDivisorSetSendMessage : SendMessage
    {
        public BaudRateDivisorSetSendMessage(string dataValue)
        {
            if (string.IsNullOrEmpty(dataValue))
                throw new ArgumentNullException("dataValue", "The baudrate divisor dataValue is empty.");

            if(dataValue.Length != 2)
                throw new ArgumentOutOfRangeException("dataValue");

            int baudDivisor;
            if(!int.TryParse(dataValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out baudDivisor))
                throw new ArgumentException("NaN");

            if(baudDivisor > 15 && baudDivisor < 0)
                throw new ArgumentOutOfRangeException("dataValue", "The dataValue is out of range.");

            this.Command = "AT BRD";
            this.Data = dataValue;
        }
    }
}
