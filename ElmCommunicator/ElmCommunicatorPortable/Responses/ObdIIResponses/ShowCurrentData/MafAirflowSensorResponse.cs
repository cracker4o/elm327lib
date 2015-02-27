using ElmCommunicatorPortable.Commands;

namespace ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData
{
    public class MafAirflowSensorResponse : ResponseMessage
    {
        public double MassAirflow { get; private set; }

        public override IReceiveMessage Parse(string message)
        {
            this.Command = this.GetCommand(ref message);
            this.Data = message.Substring(4);
            var mafBytes = this.StringToByteArray(this.Data);

            MassAirflow = (mafBytes[0]*256.0 + mafBytes[1])/100;

            return this;
        }
    }
}
