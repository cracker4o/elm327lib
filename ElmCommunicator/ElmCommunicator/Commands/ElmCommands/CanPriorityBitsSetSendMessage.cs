using System;
using System.Globalization;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class CanPriorityBitsSetSendMessage : SendMessage
    {
        public CanPriorityBitsSetSendMessage(string priorityBits)
        {
            if (string.IsNullOrEmpty(priorityBits))
                throw new ArgumentNullException("priorityBits", "The priorityBits variable is empty.");

            if (priorityBits.Length != 2)
                throw new ArgumentOutOfRangeException("priorityBits");

            int hexBits;
            if (!int.TryParse(priorityBits, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out hexBits))
                throw new ArgumentException("NaN");

            Command = "AT CP";
            Data = priorityBits;
        }
    }
}