using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class FuelSystemStatusResponse : ResponseMessage
    {
        private const int FuelSystemOneIndex = 0;
        private const int FuelSystemTwoIndex = 1;

        public FuelSystemStatus FuelSystemOne { get; private set; }

        public FuelSystemStatus FuelSystemTwo { get; private set; }

        public override IReceiveMessage Parse(string message)
        {
            Command = GetCommand(ref message);
            byte[] fuelSystems = StringToByteArray(message.Substring(4));
            FuelSystemOne = (FuelSystemStatus) fuelSystems[FuelSystemOneIndex];
            FuelSystemTwo = (FuelSystemStatus) fuelSystems[FuelSystemTwoIndex];

            return this;
        }
    }

    public enum FuelSystemStatus
    {
        OpenLoopEngineTemp = 1,
        ClosedLoopOxySensor = 2,
        OpenLoopEngineLoad = 4,
        OpenLoopSystemFailure = 8,
        ClosedLoopFeedBackSystem = 16
    }
}