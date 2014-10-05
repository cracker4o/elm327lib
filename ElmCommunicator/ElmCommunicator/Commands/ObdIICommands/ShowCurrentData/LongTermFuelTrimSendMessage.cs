namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class LongTermFuelTrimSendMessage : SendMessage
    {
        private const string ShowCurrentDataCommand = "01";
        private const string FirstFuelBankCommand = "07";
        private const string SecondFuelBankCommand = "09";

        public LongTermFuelTrimSendMessage(FuelBanks fuelBank)
        {
            Command = "01";

            switch (fuelBank)
            {
                case FuelBanks.FirstFuelBank:
                    Data = FirstFuelBankCommand;
                    break;

                case FuelBanks.SecondFuelBank:
                    Data = SecondFuelBankCommand;
                    break;
            }
        }
    }
}