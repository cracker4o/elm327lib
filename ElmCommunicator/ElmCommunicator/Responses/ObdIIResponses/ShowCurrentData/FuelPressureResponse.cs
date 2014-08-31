using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;
using Units;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class FuelPressureResponse : ResponseMessage
    {
        public override IReceiveMessage Parse(string message)
        {
            this.Command = this.GetCommand(ref message);
            this.Data = message.Substring(4);
            int value = this.HexToDec(this.Data);
            this.Pressure = (value*3)*Pressure.Kilopascal;
            return this;
        }

        public Pressure Pressure { get; private set; }
    }
}
