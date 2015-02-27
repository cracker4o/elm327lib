using System;

namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class SetWakeUpSetSendMessage : SendMessage
    {
        public SetWakeUpSetSendMessage(string data)
        {
            if (!CheckValidHexNumberByte(data))
                throw new ArgumentOutOfRangeException("data", "The data is not a HEX number");

            Command = "AT SW";
            Data = data;
        }
    }
}