using System;
using System.Globalization;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class PrintSpacesOnOffSetSendMessage : SendMessage
    {
        public PrintSpacesOnOffSetSendMessage(bool state)
        {
            Command = "AT S";
            Data = Convert.ToInt32(state).ToString(CultureInfo.InvariantCulture);
        }
    }
}