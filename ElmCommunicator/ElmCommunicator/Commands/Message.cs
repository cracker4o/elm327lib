

using System;
using System.Globalization;

namespace ElmCommunicator.Commands
{
    
    public class Message : ICommunicationMessage
    {
        public Message()
        {
            this.EndTermination = "\r\n"; //<CR><LF>
        }

        public string Command { get; set; }
        public string Data { get; set; }

        public string StartTermination { get; set; }

        public string EndTermination { get; set; }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}{3}", this.StartTermination, this.Command, this.Data, this.EndTermination);
        }

        public bool CheckValidHexNumberByte(string data)
        {
            byte validData;
            return byte.TryParse(data, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out validData);
        }
    }
}
