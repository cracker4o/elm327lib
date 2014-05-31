using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            this.Command = "AT CP";
            this.Data = priorityBits;
        }
    }
}
