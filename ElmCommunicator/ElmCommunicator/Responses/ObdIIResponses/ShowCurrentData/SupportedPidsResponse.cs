using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class SupportedPidsResponse : ResponseMessage
    {
        private BitArray _supportedPids;
        public override IReceiveMessage Parse(string message)
        {
            this.Command = this.GetCommand(ref message);
            var pids = this.StringToByteArray(message.Substring(4), true);
            this._supportedPids = new BitArray(pids);

            return this;
        }

        public BitArray SupportedPids
        {
            get { return this._supportedPids; }
            set { this._supportedPids = value; }
        }
    }
}
