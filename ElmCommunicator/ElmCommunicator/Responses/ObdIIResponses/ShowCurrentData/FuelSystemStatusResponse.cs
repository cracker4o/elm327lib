using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class FuelSystemStatusResponse : ResponseMessage
    {
        private const int FuelSystemOneIndex = 0;
        private const int FuelSystemTwoIndex = 1;

        public override IReceiveMessage Parse(string message)
        {
            this.Command = this.GetCommand(ref message);
            var fuelSystems = this.StringToByteArray(message.Substring(4));
            this.FuelSystemOne = (FuelSystemStatus) fuelSystems[FuelSystemOneIndex];
            this.FuelSystemTwo = (FuelSystemStatus)fuelSystems[FuelSystemTwoIndex];

            return this;
        }

        public FuelSystemStatus FuelSystemOne { get; private set; }

        public FuelSystemStatus FuelSystemTwo { get; private set; }
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
