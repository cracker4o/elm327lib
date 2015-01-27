using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class ShortTermFuelTrimResponse : FuelTrimResponse
    {
        public override IReceiveMessage Parse(string message)
        {
            return base.Parse(message); ;
        }
    }
}