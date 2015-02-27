using System.Collections;
using ElmCommunicatorPortable.Commands;

namespace ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData
{
    public class SupportedPidsResponse : ResponseMessage
    {
        private BitArray _supportedPids;

        public BitArray SupportedPids
        {
            get { return _supportedPids; }
            set { _supportedPids = value; }
        }

        public override IReceiveMessage Parse(string message)
        {
            Command = GetCommand(ref message);
            Data = message.Substring(4);
            byte[] pids = StringToByteArray(this.Data, true);
            _supportedPids = new BitArray(pids);

            return this;
        }
    }
}