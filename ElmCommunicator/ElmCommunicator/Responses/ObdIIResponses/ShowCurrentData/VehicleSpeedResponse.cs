using ElmCommunicator.Commands;
using Units;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class VehicleSpeedResponse : ResponseMessage
    {
        public Velocity Speed { get; set; }

        public override IReceiveMessage Parse(string message)
        {
            Command = GetCommand(ref message);
            Data = message.Substring(4);
            this.Speed = HexToDec(Data) * Velocity.KilometrePerHour;
            return this;
        }
    }
}