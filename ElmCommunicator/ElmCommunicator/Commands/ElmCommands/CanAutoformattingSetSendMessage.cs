using System;
using System.Globalization;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class CanAutoformattingSetSendMessage : SendMessage
    {
        public CanAutoformattingSetSendMessage(bool state)
        {
            Command = "AT CAF";
            Data = Convert.ToInt32(state).ToString(CultureInfo.InvariantCulture);
        }
    }
}