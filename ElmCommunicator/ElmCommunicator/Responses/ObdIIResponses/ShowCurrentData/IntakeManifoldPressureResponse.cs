using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class IntakeManifoldPressureResponse : ResponseMessage
    {
        public int Pressure { get; set; }

        public override IReceiveMessage Parse(string message)
        {
            Command = GetCommand(ref message);
            Data = message.Substring(4);
            Pressure = HexToDec(Data);

            return this;
        }
    }
}