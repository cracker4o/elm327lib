using ElmCommunicator.Commands;
using UnitsNet;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class VehicleSpeedResponse : ResponseMessage
    {
        public Speed Speed { get; set; }

        public override IReceiveMessage Parse(string message)
        {
            Command = GetCommand(ref message);
            Data = message.Substring(4);
            this.Speed = Speed.FromKilometersPerHour(HexToDec(Data));
            return this;
        }
    }
}