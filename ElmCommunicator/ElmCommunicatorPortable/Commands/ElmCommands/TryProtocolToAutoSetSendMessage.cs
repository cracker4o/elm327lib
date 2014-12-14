namespace ElmCommunicator.Commands.ElmCommands
{
    public class TryProtocolToAutoSetSendMessage : SetProtocolToAutoSendMessage
    {
        public TryProtocolToAutoSetSendMessage(byte protocolId) : base(protocolId)
        {
            Command = "AT TP A";
        }
    }
}