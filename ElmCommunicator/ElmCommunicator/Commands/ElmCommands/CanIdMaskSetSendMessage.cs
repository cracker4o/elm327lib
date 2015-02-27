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

namespace ElmCommunicator.Commands.ElmCommands
{
    public class CanIdMaskSetSendMessage : SendMessage
    {
        public CanIdMaskSetSendMessage(string dataValue)
        {
            if (string.IsNullOrEmpty(dataValue))
                throw new ArgumentNullException("dataValue", "The canMask dataValue is empty.");

            if (dataValue.Length >= 3 && dataValue.Length <= 8)
                throw new ArgumentOutOfRangeException("dataValue");

            Command = "AT CM";
            Data = dataValue;
        }
    }
}