using System.Linq;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class SetProtocolToAutoSendMessage : SendMessage
    {
        public SetProtocolToAutoSendMessage(byte protocolId)
        {
            Command = "AT SP A";
            Data = string.Format("{0}", protocolId.ToString("X").Last());
        }
    }
}