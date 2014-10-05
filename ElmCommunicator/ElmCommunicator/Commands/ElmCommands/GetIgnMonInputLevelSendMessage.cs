namespace ElmCommunicator.Commands.ElmCommands
{
    public class GetIgnMonInputLevelSendMessage : SendMessage
    {
        public GetIgnMonInputLevelSendMessage()
        {
            Command = "AT IGN";
        }
    }
}