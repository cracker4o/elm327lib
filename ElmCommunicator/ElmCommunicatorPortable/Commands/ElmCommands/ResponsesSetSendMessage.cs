using System;
using System.Globalization;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class ResponsesSetSendMessage : SendMessage
    {
        public ResponsesSetSendMessage(bool state)
        {
            Command = "AT R";
            Data = Convert.ToInt32(state).ToString(CultureInfo.InvariantCulture);
        }
    }
}