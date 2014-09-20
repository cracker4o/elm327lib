using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class IntakeManifoldPressureResponse : ResponseMessage
    {
        public override IReceiveMessage Parse(string message)
        {
            this.Command = GetCommand(ref message);
            this.Data = message.Substring(4);
            this.Pressure = this.HexToDec(this.Data);

            return this;
        }

        public int Pressure { get; set; }
    }
}
