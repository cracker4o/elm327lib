namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class MonitorDm1SendMessage : SendMessage
    {
        public MonitorDm1SendMessage()
        {
            Command = "AT DM1";
        }
    }
}