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
    public enum SupportedPidsRange
    {
        ZeroToTwenty = 0x00,
        TwentyOneToForty = 0x20,
        FortyOneToSixty = 0x40,
        SixtyOneToEighty = 0x60,
        EightyOneToHundred = 0x80,
        HundredAndOneTo192 = 0xA0,
        HundredNinetyTwoTo224 = 0xC0
    }

    public class SupportedPidsSendMessage : SendMessage
    {
        public SupportedPidsSendMessage(SupportedPidsRange range)
        {
            this.ResponseMessage = new SupportedPidsResponse();
            Command = "01";
            Data = ((byte)range).ToString("X2");
        }
    }
}