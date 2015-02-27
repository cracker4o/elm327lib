using ElmCommunicatorPortable.Commands;
using UnitsNet;

namespace ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData
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
