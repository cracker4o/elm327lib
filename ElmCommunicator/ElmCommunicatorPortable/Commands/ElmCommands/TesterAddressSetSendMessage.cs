using System;

namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class TesterAddressSetSendMessage : SendMessage
    {
        public TesterAddressSetSendMessage(string data)
        {
            if (!CheckValidHexNumberByte(data))
                throw new ArgumentOutOfRangeException("data", "The data is not a HEX number");

            Command = "AT TA";
            Data = data;
        }
    }
}