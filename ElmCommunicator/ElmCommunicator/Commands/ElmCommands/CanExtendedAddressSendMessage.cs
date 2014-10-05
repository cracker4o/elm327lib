namespace ElmCommunicator.Commands.ElmCommands
{
    public class CanExtendedAddressSendMessage : SendMessage
    {
        public CanExtendedAddressSendMessage()
        {
            Command = "AT CEA";
        }
    }
}