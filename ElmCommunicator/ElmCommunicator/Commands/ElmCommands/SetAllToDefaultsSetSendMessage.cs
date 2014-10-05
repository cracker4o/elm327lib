using System;
using System.Globalization;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class SetAllToDefaultsSetSendMessage : SendMessage
    {
        public SetAllToDefaultsSetSendMessage()
        {
            Command = "AT D";
        }

        public SetAllToDefaultsSetSendMessage(bool dlcDigitState)
            : this()
        {
            Data = Convert.ToInt32(dlcDigitState).ToString(CultureInfo.InvariantCulture);
        }
    }
}