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
            Command = ShowCurrentDataCommand;

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