using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses
{
    public abstract class ResponseMessage : IReceiveMessage
    {
        public string Command { get; set; }
        public string Data { get; set; }
        public string StartTermination { get; set; }
        public string EndTermination { get; set; }
        public abstract IReceiveMessage Parse(string message);
        public int HexToDec(string hex)
        {
            if(string.IsNullOrEmpty(hex))
                throw new ArgumentNullException("hex");

            return int.Parse(hex, NumberStyles.HexNumber);
        }
    }
}
