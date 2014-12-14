using System;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class ProgramParameterSetSendMessage : SendMessage
    {
        public ProgramParameterSetSendMessage(string data, bool state)
        {
            if (string.IsNullOrEmpty(data))
                throw new ArgumentNullException("data");

            if (data.Length != 2 || !CheckValidHexNumberByte(data))
                throw new ArgumentOutOfRangeException("data");

            Command = "AT PP";
            Data = string.Format("{0} {1}", data, state ? "ON" : "OFF");
        }
    }
}