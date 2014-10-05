using System;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class BaudRateDivisorSendMessage : SendMessage
    {
        public BaudRateDivisorSendMessage()
        {
            Command = "AT BRD";
        }

        public BaudRateDivisorSendMessage(string data)
            : this()
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException("data", "The data is empty");
            }

            if (!CheckValidHexNumberByte(data))
            {
                throw new ArgumentOutOfRangeException("data", "The data is not a valid HEX number.");
            }

            Data = data;
        }
    }
}