namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class LowPowerModeEnableSendMessage : SendMessage
    {
        public LowPowerModeEnableSendMessage()
        {
            Command = "AT LP";
        }
    }
}