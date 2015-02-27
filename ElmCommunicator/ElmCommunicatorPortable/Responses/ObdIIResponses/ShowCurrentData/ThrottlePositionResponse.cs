using ElmCommunicatorPortable.Commands;

namespace ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData
{
    public class ThrottlePositionResponse : ResponseMessage
    {
        public int ThrottlePosition { get; set; } 

        public override IReceiveMessage Parse(string message)
        {
            Command = GetCommand(ref message);
            Data = message.Substring(4);
            this.ThrottlePosition = HexToDec(Data) * 100/255;
            return this;
        }
    }
}
