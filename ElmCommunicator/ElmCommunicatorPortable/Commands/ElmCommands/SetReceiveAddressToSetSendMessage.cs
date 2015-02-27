using System;

namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class SetReceiveAddressToSetSendMessage : SendMessage
    {
        public SetReceiveAddressToSetSendMessage(string data)
        {
            if (CheckValidHexNumberByte(data))
                throw new ArgumentOutOfRangeException("data", "The data parameter is not a HEX number.");

            Command = "AT SR";
            Data = data;
        }
    }
}