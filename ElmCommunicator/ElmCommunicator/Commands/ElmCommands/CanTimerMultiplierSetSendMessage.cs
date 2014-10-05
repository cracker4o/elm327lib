using System;
using System.Globalization;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class CanTimerMultiplierSetSendMessage : SendMessage
    {
        public CanTimerMultiplierSetSendMessage(int multiplier)
        {
            if (multiplier < 1 && multiplier > 5)
                throw new ArgumentOutOfRangeException("multiplier");

            Command = "AT CTM";
            Data = multiplier.ToString(CultureInfo.InvariantCulture);
        }
    }
}