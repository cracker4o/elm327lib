using System;
using System.Globalization;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class EchoCommandsSetSendMessage : SendMessage
    {
        public EchoCommandsSetSendMessage(bool state)
        {
            Command = "AT E";
            Data = Convert.ToInt32(state).ToString(CultureInfo.InvariantCulture);
        }
    }
}