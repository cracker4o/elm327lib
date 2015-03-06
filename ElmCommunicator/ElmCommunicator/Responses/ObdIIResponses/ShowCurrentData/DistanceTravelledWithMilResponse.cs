using ElmCommunicator.Commands;

using UnitsNet;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class DistanceTravelledWithMilResponse : ResponseMessage
    {
        public Length Distance { get; private set; }

        public override string ExpectedCommand
        {
            get
            {
                return "21";
            }
        }

        public override IReceiveMessage Parse(string message)
        {
            this.Command = this.GetCommand(ref message);
            if (!this.IsValid())
            {
                return null;
            }

            this.Data = message.Substring(4);
            var distanceBytes = this.StringToByteArray(this.Data, false);
            this.Distance = Length.FromKilometers((distanceBytes[0] * 256) + distanceBytes[1]);

            return this;
        }
    }
}
