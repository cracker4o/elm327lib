using System;

namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class SetProtocolBParametersSetSendMessage : SendMessage
    {
        public SetProtocolBParametersSetSendMessage(string xx, string yy)
        {
            if (xx.Length != 2)
                throw new ArgumentOutOfRangeException("xx");

            if (yy.Length != 2)
                throw new ArgumentOutOfRangeException("yy");

            if (!CheckValidHexNumberByte(xx) || !CheckValidHexNumberByte(yy))
                throw new ArgumentException("The arguments are not HEX numbers");

            Command = "AT PB";
            Data = string.Format("{0} {1}", xx, yy);
        }
    }
}