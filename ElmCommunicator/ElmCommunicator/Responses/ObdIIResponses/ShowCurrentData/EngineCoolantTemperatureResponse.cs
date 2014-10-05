using ElmCommunicator.Commands;
using Units;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class EngineCoolantTemperatureResponse : ResponseMessage
    {
        private const int AdjustmentCoefficient = 40;

        public EngineCoolantTemperatureResponse()
        {
            Temperature = -40*Temperature.DegreeCelsius;
        }

        public Temperature Temperature { get; private set; }

        public override IReceiveMessage Parse(string message)
        {
            Command = GetCommand(ref message);
            Data = message.Substring(4);
            double data = StringToByteArray(Data)[0] - AdjustmentCoefficient;
            Temperature = data*Temperature.DegreeCelsius;

            return this;
        }
    }
}