using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class FlowControlSetModeSetSendMessage : SendMessage
    {
        public FlowControlSetModeSetSendMessage(char mode)
        {
            if(!char.IsDigit(mode))
                throw new ArgumentException("The mode parameter is not a digit.","mode");

            var modeDigit = Convert.ToInt32(mode);
            if (modeDigit > 2 && modeDigit < 0)
                throw new ArgumentOutOfRangeException("mode");

            this.Command = "AT SM";
            this.Data = mode.ToString(CultureInfo.InvariantCulture);
        }
    }
}
