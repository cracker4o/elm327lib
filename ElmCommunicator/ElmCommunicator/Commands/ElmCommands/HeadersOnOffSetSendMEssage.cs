using System;
using System.Globalization;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class HeadersOnOffSetSendMEssage : SendMessage
    {
        public HeadersOnOffSetSendMEssage(bool state)
        {
            Command = "AT H";
            Data = Convert.ToInt32(state).ToString(CultureInfo.InvariantCulture);
        }
    }
}