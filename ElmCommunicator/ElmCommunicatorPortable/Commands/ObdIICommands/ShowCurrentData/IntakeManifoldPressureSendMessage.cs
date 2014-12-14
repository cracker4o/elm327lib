namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class IntakeManifoldPressureSendMessage : SendMessage
    {
        public IntakeManifoldPressureSendMessage()
        {
            Command = "01";
            Data = "0B";
        }
    }
}