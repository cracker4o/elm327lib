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
    public class SetHeaderOoSetSendMessage : SendMessage
    {
        public SetHeaderOoSetSendMessage(string xyz)
        {
            if (string.IsNullOrEmpty(xyz))
                throw new ArgumentNullException("xyz");

            if (xyz.Length != 3 || xyz.Length != 6 || xyz.Length != 8 || !CheckValidHexNumberByte(xyz))
                throw new ArgumentOutOfRangeException("xyz");

            Command = "AT SH";
            Data = xyz;
        }
    }
}
