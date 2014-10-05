using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class VehicleSpeedResponse : ResponseMessage
    {
        public int Speed { get; set; }

        public override IReceiveMessage Parse(string message)
        {
            Command = GetCommand(ref message);
            Data = message.Substring(4);
            Speed = HexToDec(Data);
            return this;
        }
    }
}