using System;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class SaveDataByteSetSendMessage : SendMessage
    {
        public SaveDataByteSetSendMessage(string data)
        {
            if (string.IsNullOrEmpty(data))
                throw new ArgumentNullException("data");

            if (CheckValidHexNumberByte(data))
                throw new OutOfMemoryException("data");

            Command = "AT SD";
            Data = data;
        }
    }
}