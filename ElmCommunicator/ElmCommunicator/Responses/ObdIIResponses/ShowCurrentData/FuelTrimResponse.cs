using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class FuelTrimResponse : ResponseMessage
    {
        private double _fuelTrim;

        public double FuelTrim
        {
            get { return _fuelTrim; }
        }

        public override IReceiveMessage Parse(string message)
        {
            Command = GetCommand(ref message);
            Data = message.Substring(4);
            int value = HexToDec(Data);
            _fuelTrim = (value - 128f)*(100f/128f);
            return this;
        }
    }
}