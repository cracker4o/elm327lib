using System;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class IsoInitAddressSetSendMessage : SendMessage
    {
        public IsoInitAddressSetSendMessage(string address)
        {
            if (!CheckValidHexNumberByte(address))
                throw new ArgumentException("Invalid argument - address");

            Command = "AT IIA";
            Data = address;
        }
    }
}