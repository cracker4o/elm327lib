using System;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class ReceiveAddressSetSendMessage : SendMessage
    {
        public ReceiveAddressSetSendMessage(string data)
        {
            if (string.IsNullOrEmpty(data))
                throw new ArgumentNullException("data");

            if (!CheckValidHexNumberByte(data))
                throw new ArgumentOutOfRangeException("data");

            Command = "AT RA";
            Data = data;
        }
    }
}