namespace ElmCommunicator.Commands.ElmCommands
{
    public class TryProtocolSetSendMessage : SetProtocolSetSendMessage
    {
        public TryProtocolSetSendMessage(byte protocolId, bool reset = false) : base(protocolId, reset)
        {
            Command = "AT TP";
        }
    }
}