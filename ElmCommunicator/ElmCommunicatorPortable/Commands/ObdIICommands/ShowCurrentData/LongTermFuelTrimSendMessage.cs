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
using ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicatorPortable.Commands.ObdIICommands.ShowCurrentData
{
    public class LongTermFuelTrimSendMessage : SendMessage
    {
        private const string ShowCurrentDataCommand = "01";
        private const string FirstFuelBankCommand = "07";
        private const string SecondFuelBankCommand = "09";

        public LongTermFuelTrimSendMessage(FuelBanks fuelBank)
        {
            this.ResponseMessage = new FuelTrimResponse();
            Command = "01";

            switch (fuelBank)
            {
                case FuelBanks.FirstFuelBank:
                    Data = FirstFuelBankCommand;
                    break;

                case FuelBanks.SecondFuelBank:
                    Data = SecondFuelBankCommand;
                    break;
            }
        }
    }
}