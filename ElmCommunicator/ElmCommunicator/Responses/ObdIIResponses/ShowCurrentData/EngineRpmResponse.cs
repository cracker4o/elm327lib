// Copyright 2015 Tosho Toshev
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
using System;
using ElmCommunicator.Commands;
using UnitsNet;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
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