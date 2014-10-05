using System;
using System.Globalization;
using System.Linq;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class SetProtocolSetSendMessage : SendMessage
    {
        public SetProtocolSetSendMessage(byte protocolId, bool reset = false)
        {
            if (protocolId > 12)
                throw new ArgumentOutOfRangeException("protocolId");

            Command = "AT SP";
            if (reset)
            {
                Data = "00";
            }
            else
            {
                Data = protocolId.ToString("X")
                    .Last()
                    .ToString(CultureInfo.InvariantCulture);
            }
        }
    }
}