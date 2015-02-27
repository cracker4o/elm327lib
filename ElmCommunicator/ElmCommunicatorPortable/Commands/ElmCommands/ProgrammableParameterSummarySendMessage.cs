namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class ProgrammableParameterSummarySendMessage : SendMessage
    {
        public ProgrammableParameterSummarySendMessage()
        {
            Command = "AT PPS";
        }
    }
}