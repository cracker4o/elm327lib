using ElmCommunicatorPortable.Commands;

namespace ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData
{
    public class TimingAdvanceResponse : ResponseMessage
    {
        public override IReceiveMessage Parse(string message)
        {
            this.Command = this.GetCommand(ref message);
            this.Data = message.Substring(4);
            TimingAdvance = (this.HexToDec(this.Data) - 128f) / 2;
            return this;
        }

        public double TimingAdvance { get; private set; }
    }
}
