using System;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class MonitorForPgnSetSendMessage : SendMessage
    {
        public MonitorForPgnSetSendMessage(string data, int? times = null)
        {
            if (data.Length != 4 || data.Length != 6)
                throw new ArgumentOutOfRangeException("data");

            if (!CheckValidHexNumberByte(data))
                throw new ArgumentException("The data variable is not a HEX number.");

            Command = "AT MP";
            Data = data;
            if (times.HasValue)
            {
                Data = string.Concat(Data, times.ToString());
            }
        }
    }
}