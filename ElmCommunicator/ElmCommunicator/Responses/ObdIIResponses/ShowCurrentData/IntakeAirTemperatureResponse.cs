using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElmCommunicator.Commands;

using UnitsNet;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class IntakeAirTemperatureResponse : ResponseMessage
    {
        public override IReceiveMessage Parse(string message)
        {
            this.Command = this.GetCommand(ref message);
            this.Data = message.Substring(4);
            this.Temperature = Temperature.FromDegreesCelsius(this.HexToDec(this.Data) - 40);
            return this;
        }

        public Temperature Temperature { get; set; }
    }
}
