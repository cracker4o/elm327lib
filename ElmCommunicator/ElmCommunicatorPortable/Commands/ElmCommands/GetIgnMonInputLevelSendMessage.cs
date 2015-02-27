namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class GetIgnMonInputLevelSendMessage : SendMessage
    {
        public GetIgnMonInputLevelSendMessage()
        {
            Command = "AT IGN";
        }
    }
}