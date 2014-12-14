namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class FreezeDtcSendMessage : SendMessage
    {
        public FreezeDtcSendMessage()
        {
            Command = "01";
            Data = "02";
        }
    }
}