namespace ElmCommunicator.Commands.ElmCommands
{
    public class ForgetEventsSendMessage : SendMessage
    {
        public ForgetEventsSendMessage()
        {
            Command = "AT FE";
        }
    }
}