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
using System.Globalization;
using ElmCommunicator.Responses.ElmResponses;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class BaudRateTimeoutSetSendMessage : SendMessage
    {
        public BaudRateTimeoutSetSendMessage(string dataValue)
        {
            this.ResponseMessage = new CommonElmResponseMessage();
            if (string.IsNullOrEmpty(dataValue))
                throw new ArgumentNullException("dataValue", "The baudrate dataValue is empty.");

            if (dataValue.Length != 2)
                throw new ArgumentOutOfRangeException("dataValue");

            int baudDivisor;
            if (!int.TryParse(dataValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out baudDivisor))
                throw new ArgumentException("NaN");

            Command = "AT BRT";
            Data = dataValue;
        }
    }
}