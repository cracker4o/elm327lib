using System;
using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class EngineRpmResponse : ResponseMessage
    {
        public double Rpm;

        public override IReceiveMessage Parse(string message)
        {
            Command = GetCommand(ref message);
            Data = message.Substring(4);
            Rpm = CalculateRpm(Data);

            return this;
        }

        public double CalculateRpm(string data)
        {
            byte[] rpmBytes = StringToByteArray(data);
            if (rpmBytes != null)
            {
                return (rpmBytes[0]*256 + rpmBytes[1])/4f;
            }

            throw new NullReferenceException("rpmBytes");
        }
    }
}