namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class MonitorAllMessagesSendMessage : SendMessage
    {
        public MonitorAllMessagesSendMessage()
        {
            Command = "AT MA";
        }
    }
}