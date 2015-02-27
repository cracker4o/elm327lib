using System;
using ElmCommunicatorPortable.Commands;
using UnitsNet;

namespace ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData
{
    public class EngineRpmResponse : ResponseMessage
    {
        public RotationalSpeed  Rpm;

        public override IReceiveMessage Parse(string message)
        {
            Command = GetCommand(ref message);
            Data = message.Substring(4);
            Rpm = CalculateRpm(Data);

            return this;
        }

        public RotationalSpeed CalculateRpm(string data)
        {
            byte[] rpmBytes = StringToByteArray(data);
            if (rpmBytes != null)
            {
                double rpm = (rpmBytes[0]*256 + rpmBytes[1])/4f;
                return RotationalSpeed.FromRevolutionsPerMinute(rpm);
            }

            throw new NullReferenceException("rpmBytes");
        }
    }
}