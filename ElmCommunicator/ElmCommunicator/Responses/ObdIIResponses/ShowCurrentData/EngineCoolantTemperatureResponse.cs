using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;
using Units;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{

    public class EngineCoolantTemperatureResponse : ResponseMessage
    {
        private const int AdjustmentCoefficient = 40;

        public EngineCoolantTemperatureResponse()
        {
            this.Temperature = -40*Temperature.DegreeCelsius;
        }

        public override IReceiveMessage Parse(string message)
        {
            this.Command = this.GetCommand(ref message);
            this.Data = message.Substring(4);
            double data = StringToByteArray(this.Data)[0] - AdjustmentCoefficient;
            this.Temperature =  data*Temperature.DegreeCelsius;

            return this;
        }

        public Temperature Temperature { get; private set; }
    }
}
