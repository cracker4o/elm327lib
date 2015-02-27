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

namespace ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData
{
    public class FuelSystemStatusResponse : ResponseMessage
    {
        private const int FuelSystemOneIndex = 0;
        private const int FuelSystemTwoIndex = 1;

        public FuelSystemStatus FuelSystemOne { get; private set; }

        public FuelSystemStatus FuelSystemTwo { get; private set; }

        public override IReceiveMessage Parse(string message)
        {
            Command = GetCommand(ref message);
            byte[] fuelSystems = StringToByteArray(message.Substring(4));
            FuelSystemOne = (FuelSystemStatus) fuelSystems[FuelSystemOneIndex];
            FuelSystemTwo = (FuelSystemStatus) fuelSystems[FuelSystemTwoIndex];

            return this;
        }
    }

    public enum FuelSystemStatus
    {
        OpenLoopEngineTemp = 1,
        ClosedLoopOxySensor = 2,
        OpenLoopEngineLoad = 4,
        OpenLoopSystemFailure = 8,
        ClosedLoopFeedBackSystem = 16
    }
}