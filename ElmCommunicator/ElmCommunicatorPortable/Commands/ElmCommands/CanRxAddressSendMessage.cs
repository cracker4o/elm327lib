namespace ElmCommunicator.Commands.ElmCommands
{
    public class CanRxAddressSendMessage : SendMessage
    {
        public CanRxAddressSendMessage()
        {
            Command = "AT CRA";
        }
    }
}