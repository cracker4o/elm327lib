using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class LongTermFuelTrimSendMessage : SendMessage
    {
        private const string ShowCurrentDataCommand = "01";
        private const string FirstFuelBankCommand = "07";
        private const string SecondFuelBankCommand = "09";

        public LongTermFuelTrimSendMessage(FuelBanks fuelBank)
        {
            this.Command = "01";

            switch (fuelBank)
            {
                case FuelBanks.FirstFuelBank:
                    this.Data = FirstFuelBankCommand;
                    break;

                case FuelBanks.SecondFuelBank:
                    this.Data = SecondFuelBankCommand;
                    break;
            }
        }
    }
}
