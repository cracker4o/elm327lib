using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class EngineRpmResponse : ResponseMessage
    {
        public double Rpm;

        public override IReceiveMessage Parse(string message)
        {
            this.Command = this.GetCommand(ref message);
            this.Data = message.Substring(4);
            this.Rpm = this.CalculateRpm(this.Data);

            return this;
        }

        public double CalculateRpm(string data)
        {
            var rpmBytes = this.StringToByteArray(data);
            if (rpmBytes != null)
            {
                return (rpmBytes[0]*256 + rpmBytes[1])/4f;

            }

            throw new NullReferenceException("rpmBytes");
        }

    }
}
