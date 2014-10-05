namespace ElmCommunicator.Commands.ElmCommands
{
    public class StandardSequenceForSerchesSendMessage : SendMessage
    {
        public StandardSequenceForSerchesSendMessage()
        {
            Command = "AT SS";
        }
    }
}