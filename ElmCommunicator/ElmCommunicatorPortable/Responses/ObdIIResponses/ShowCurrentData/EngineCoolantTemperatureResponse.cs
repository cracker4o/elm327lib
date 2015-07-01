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

using ElmCommunicatorPortable.Commands;
using UnitsNet;

namespace ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData
{
    public class EngineCoolantTemperatureResponse : ResponseMessage
    {
        private const int AdjustmentCoefficient = 40;

        public EngineCoolantTemperatureResponse()
        {
            Temperature = Temperature.FromDegreesCelsius(-40);
        }

        public Temperature Temperature { get; private set; }

        public override string ExpectedCommand
        {
            get
            {
                return "05";
            }
        }

        public override IReceiveMessage Parse(string message)
        {
            Command = GetCommand(ref message);
            if (!this.IsValid())
            {
                return null;
            }

            Data = message.Substring(4);
            double data = StringToByteArray(Data)[0] - AdjustmentCoefficient;
            Temperature = Temperature.FromDegreesCelsius(data);

            return this;
        }
    }
}