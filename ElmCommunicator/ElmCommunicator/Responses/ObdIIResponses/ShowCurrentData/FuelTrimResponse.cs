using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class FuelTrimResponse : ResponseMessage
    {
        private double _fuelTrim;

        public override IReceiveMessage Parse(string message)
        {
            this.Command = this.GetCommand(ref message);
            this.Data = message.Substring(4);
            int value = this.HexToDec(this.Data);
            this._fuelTrim = (value - 128f)*(100f/128f);
            return this;
        }

        public double FuelTrim
        {
            get { return _fuelTrim; }
        }
    }
}
