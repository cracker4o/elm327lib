using System;

namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class SetTimeoutSetSendMessage : SendMessage
    {
        public SetTimeoutSetSendMessage(string data)
        {
            if (!CheckValidHexNumberByte(data))
                throw new ArgumentOutOfRangeException("data", "The data is not a HEX number");

            Command = "AT ST";
            Data = data;
        }
    }
}