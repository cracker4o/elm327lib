using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public enum FuelBanks
    {
        FirstFuelBank = 1,
        SecondFuelBank = 2
    }

    public class ShortTermFuelTrimSendMessage : SendMessage
    {
        private const string ShowCurrentDataCommand = "01";
        private const string FirstFuelBankCommand = "06";
        private const string SecondFuelBankCommand = "08";

        public ShortTermFuelTrimSendMessage(FuelBanks fuelBank)
        {
            this.Command = ShowCurrentDataCommand;

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
