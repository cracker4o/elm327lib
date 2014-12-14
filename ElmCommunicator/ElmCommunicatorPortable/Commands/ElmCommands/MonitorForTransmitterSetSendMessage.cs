using System;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class MonitorForTransmitterSetSendMessage : SendMessage
    {
        public MonitorForTransmitterSetSendMessage(string data)
        {
            if (data.Length != 2)
                throw new ArgumentOutOfRangeException("data");

            if (!CheckValidHexNumberByte(data))
                throw new ArgumentException("The data value is not a HEX number");

            Command = "AT MT";
            Data = data;
        }
    }
}