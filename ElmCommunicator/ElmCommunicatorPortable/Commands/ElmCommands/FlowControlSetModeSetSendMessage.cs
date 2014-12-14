using System;
using System.Globalization;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class FlowControlSetModeSetSendMessage : SendMessage
    {
        public FlowControlSetModeSetSendMessage(char mode)
        {
            if (!char.IsDigit(mode))
                throw new ArgumentException("The mode parameter is not a digit.", "mode");

            int modeDigit = Convert.ToInt32(mode);
            if (modeDigit > 2 && modeDigit < 0)
                throw new ArgumentOutOfRangeException("mode");

            Command = "AT SM";
            Data = mode.ToString();
        }
    }
}