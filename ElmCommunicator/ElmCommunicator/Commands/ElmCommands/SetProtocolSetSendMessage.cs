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
using System.Linq;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class SetProtocolSetSendMessage : SendMessage
    {
        public SetProtocolSetSendMessage(byte protocolId, bool reset = false)
        {
            if (protocolId > 12)
                throw new ArgumentOutOfRangeException("protocolId");

            Command = "AT SP";
            if (reset)
            {
                Data = "00";
            }
            else
            {
                Data = protocolId.ToString("X")
                    .Last()
                    .ToString(CultureInfo.InvariantCulture);
            }
        }
    }
}