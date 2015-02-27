namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class CanExtendedAddressSendMessage : SendMessage
    {
        public CanExtendedAddressSendMessage()
        {
            Command = "AT CEA";
        }
    }
}