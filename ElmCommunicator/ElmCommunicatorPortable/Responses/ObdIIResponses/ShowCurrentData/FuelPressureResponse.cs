using ElmCommunicator.Commands;
using UnitsNet;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class FuelPressureResponse : ResponseMessage
    {
        public Pressure Pressure { get; private set; }

        public override IReceiveMessage Parse(string message)
        {
            Command = GetCommand(ref message);
            Data = message.Substring(4);
            int value = HexToDec(Data);
            Pressure = Pressure.FromKilopascals(value*3);
            return this;
        }
    }
}