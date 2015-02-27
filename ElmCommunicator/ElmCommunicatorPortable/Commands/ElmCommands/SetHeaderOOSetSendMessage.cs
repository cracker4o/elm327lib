using System;

namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class SetHeaderOoSetSendMessage : SendMessage
    {
        public SetHeaderOoSetSendMessage(string xyz)
        {
            if (string.IsNullOrEmpty(xyz))
                throw new ArgumentNullException("xyz");

            if (xyz.Length != 3 || xyz.Length != 6 || xyz.Length != 8 || !CheckValidHexNumberByte(xyz))
                throw new ArgumentOutOfRangeException("xyz");

            Command = "AT SH";
            Data = xyz;
        }
    }
}