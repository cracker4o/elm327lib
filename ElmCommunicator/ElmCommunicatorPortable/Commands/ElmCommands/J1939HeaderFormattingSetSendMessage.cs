using System;
using System.Globalization;

namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class J1939HeaderFormattingSetSendMessage : SendMessage
    {
        public J1939HeaderFormattingSetSendMessage(bool state)
        {
            Command = "AT JHF";
            Data = Convert.ToInt32(state).ToString(CultureInfo.InvariantCulture);
        }
    }
}