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

namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class MonitorForPgnSetSendMessage : SendMessage
    {
        public MonitorForPgnSetSendMessage(string data, int? times = null)
        {
            if (data.Length != 4 || data.Length != 6)
                throw new ArgumentOutOfRangeException("data");

            if (!CheckValidHexNumberByte(data))
                throw new ArgumentException("The data variable is not a HEX number.");

            Command = "AT MP";
            Data = data;
            if (times.HasValue)
            {
                Data = string.Concat(Data, times.ToString());
            }
        }
    }
}