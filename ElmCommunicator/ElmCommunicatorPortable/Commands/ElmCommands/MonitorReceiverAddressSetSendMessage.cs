using System;

namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class MonitorReceiverAddressSetSendMessage : SendMessage
    {
        public MonitorReceiverAddressSetSendMessage(string data)
        {
            if (Data.Length != 2)
                throw new ArgumentOutOfRangeException("data");

            if (CheckValidHexNumberByte(data))
                throw new ArgumentException("The data is not a hex number");

            Command = "AT MR";
            Data = data;
        }
    }
}