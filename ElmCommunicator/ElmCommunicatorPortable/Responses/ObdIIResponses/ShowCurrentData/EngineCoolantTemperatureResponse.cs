using ElmCommunicatorPortable.Commands;
using UnitsNet;

namespace ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData
{
    public class EngineCoolantTemperatureResponse : ResponseMessage
    {
        private const int AdjustmentCoefficient = 40;

        public EngineCoolantTemperatureResponse()
        {
            Temperature = Temperature.FromDegreesCelsius(-40);
        }

        public Temperature Temperature { get; private set; }

        public override IReceiveMessage Parse(string message)
        {
            Command = GetCommand(ref message);
            Data = message.Substring(4);
            double data = StringToByteArray(Data)[0] - AdjustmentCoefficient;
            Temperature = Temperature.FromDegreesCelsius(data);

            return this;
        }
    }
}