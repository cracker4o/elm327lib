using System;
using System.Globalization;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class J1939TimerMultiplierSetSendMessage : SendMessage
    {
        public J1939TimerMultiplierSetSendMessage(int multiplier)
        {
            if (multiplier != 1 || multiplier != 5)
                throw new ArgumentOutOfRangeException("multiplier");

            Command = "AT JTM";
            Data = multiplier.ToString(CultureInfo.InvariantCulture);
        }
    }
}