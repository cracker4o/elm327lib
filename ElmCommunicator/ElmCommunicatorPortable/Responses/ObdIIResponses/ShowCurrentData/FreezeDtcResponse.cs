using ElmCommunicatorPortable.Commands;

namespace ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData
{
    public class FreezeDtcResponse : ResponseMessage
    {
        public byte[] ReceivedBytes { get; private set; }

        public override IReceiveMessage Parse(string message)
        {
            message = message.Replace(" ", string.Empty);
            Command = message.Substring(0, 4);
            message = message.Substring(4);
            byte[] bytes = StringToByteArray(message, false);
            ReceivedBytes = bytes;

            return this;
        }
    }
}