using System.Globalization;

namespace ElmCommunicatorPortable.Commands
{
    /// <summary>
    ///     A base message class for communication with the ELM327 device
    /// </summary>
    public class SendMessage : ISendMessage
    {
        public SendMessage()
        {
            EndTermination = "\r\n"; //<CR><LF>
        }

        public string Command { get; set; }
        public string Data { get; set; }

        public string StartTermination { get; set; }

        public string EndTermination { get; set; }
        public IReceiveMessage ResponseMessage { get; set; }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}{3}", StartTermination, Command, Data, EndTermination);
        }

        internal bool CheckValidHexNumberByte(string data)
        {
            int validData;
            return int.TryParse(data, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out validData);
        }
    }
}