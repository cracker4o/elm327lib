using System;

namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class ProgParamSetValueSetSendMessage : SendMessage
    {
        public ProgParamSetValueSetSendMessage(string data, string value)
        {
            if (string.IsNullOrEmpty(data))
                throw new ArgumentNullException("data");

            if (data.Length != 2 || !CheckValidHexNumberByte(data))
                throw new ArgumentOutOfRangeException("data");

            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException("value");

            Command = "AT PP";
            Data = string.Format("{0} SV {1}", data, value);
        }
    }
}