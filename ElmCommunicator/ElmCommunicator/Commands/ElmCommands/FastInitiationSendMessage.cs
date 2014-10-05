namespace ElmCommunicator.Commands.ElmCommands
{
    public class FastInitiationSendMessage : SendMessage
    {
        public FastInitiationSendMessage()
        {
            Command = "AT FI";
        }
    }
}