namespace ElmCommunicator.Commands.ElmCommands
{
    public class DescribeCurrentProtocolSendMessage : SendMessage
    {
        public DescribeCurrentProtocolSendMessage(bool byNumber = false)
        {
            Command = byNumber ? "AT DPN" : "AT DP";
        }
    }
}