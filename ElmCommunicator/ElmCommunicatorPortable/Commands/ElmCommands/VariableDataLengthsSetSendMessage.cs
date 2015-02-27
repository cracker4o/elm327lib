using System;
using System.Globalization;

namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class VariableDataLengthsSetSendMessage : SendMessage
    {
        public VariableDataLengthsSetSendMessage(bool state)
        {
            Command = "AT V";
            Data = Convert.ToInt32(state).ToString(CultureInfo.InvariantCulture);
        }
    }
}