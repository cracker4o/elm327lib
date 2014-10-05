namespace ElmCommunicator.Commands.ElmCommands
{
    public class PerformSlowInitiationSendMessage : SendMessage
    {
        public PerformSlowInitiationSendMessage()
        {
            Command = "AT SI";
        }
    }
}