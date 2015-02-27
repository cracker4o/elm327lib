using System;
using System.Globalization;

namespace ElmCommunicatorPortable.Commands.ElmCommands
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