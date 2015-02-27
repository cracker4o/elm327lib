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
    public class InFrameResponseControlSetSendMessage : SendMessage
    {
        public InFrameResponseControlSetSendMessage(string mode)
        {
            int modeId;
            if (int.TryParse(mode, out modeId))
            {
                if (modeId < 0 || modeId > 2)
                    throw new ArgumentOutOfRangeException("mode");
            }
            else
            {
                if (!string.Equals(mode, "S") && !string.Equals(mode, "H"))
                    throw new ArgumentOutOfRangeException("mode", "The IFR mode is not valid.");
            }

            Command = "AT IFR";
            Data = mode;
        }
    }
}