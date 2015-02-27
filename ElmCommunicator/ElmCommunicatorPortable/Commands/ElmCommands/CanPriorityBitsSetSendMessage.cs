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

namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class CanPriorityBitsSetSendMessage : SendMessage
    {
        public CanPriorityBitsSetSendMessage(string priorityBits)
        {
            if (string.IsNullOrEmpty(priorityBits))
                throw new ArgumentNullException("priorityBits", "The priorityBits variable is empty.");

            if (priorityBits.Length != 2)
                throw new ArgumentOutOfRangeException("priorityBits");

            int hexBits;
            if (!int.TryParse(priorityBits, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out hexBits))
                throw new ArgumentException("NaN");

            Command = "AT CP";
            Data = priorityBits;
        }
    }
}