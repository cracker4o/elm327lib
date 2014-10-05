namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class FuelSystemStatusSendMessage : SendMessage
    {
        public FuelSystemStatusSendMessage()
        {
            Command = "01";
            Data = "03";
        }
    }
}