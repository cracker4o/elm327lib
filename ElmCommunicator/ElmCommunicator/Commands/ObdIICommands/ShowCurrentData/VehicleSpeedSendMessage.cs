namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class VehicleSpeedSendMessage : SendMessage
    {
        public VehicleSpeedSendMessage()
        {
            Command = "01";
            Data = "0D";
        }
    }
}