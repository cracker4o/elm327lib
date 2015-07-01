using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicatorPortable.Commands;
using UnitsNet;

namespace ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData
{
    public class ControlModuleVoltageResponse : ResponseMessage
    {
        public override string ExpectedCommand
        {
            get
            {
                return "42";
            }
        }

        public override IReceiveMessage Parse(string message)
        {
            Command = GetCommand(ref message);
            if (!this.IsValid())
            {
                return null;
            }

            Data = message.Substring(4);
            Voltage = CalculateRpm(Data);

            return this;
        }

        public ElectricPotential Voltage { get; set; }

        public ElectricPotential CalculateRpm(string data)
        {
            byte[] voltageBytes = StringToByteArray(data);
            if (voltageBytes != null)
            {
                //((A * 256) + B) / 1000
                double volts = ((voltageBytes[0] * 256) + voltageBytes[1]) / 1000f;
                return ElectricPotential.FromVolts(volts);
            }

            throw new NullReferenceException("volts");
        }
    }
}
