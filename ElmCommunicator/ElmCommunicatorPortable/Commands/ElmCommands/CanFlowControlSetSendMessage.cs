using System;
using System.Globalization;

namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class CanFlowControlSetSendMessage : SendMessage
    {
        public CanFlowControlSetSendMessage(bool state)
        {
            Command = "AT CFC";
            Data = Convert.ToInt32(state).ToString(CultureInfo.InvariantCulture);
        }
    }
}