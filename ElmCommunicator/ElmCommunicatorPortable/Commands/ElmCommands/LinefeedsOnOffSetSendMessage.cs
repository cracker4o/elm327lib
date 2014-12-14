using System;
using System.Globalization;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class LinefeedsOnOffSetSendMessage : SendMessage
    {
        public LinefeedsOnOffSetSendMessage(bool state)
        {
            Command = "AT L";
            Data = Convert.ToInt32(state).ToString(CultureInfo.InvariantCulture);
        }
    }
}