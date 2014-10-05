namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class FuelPressureSendMessage : SendMessage
    {
        public FuelPressureSendMessage()
        {
            Command = "01";
            Data = "0A";
        }
    }
}