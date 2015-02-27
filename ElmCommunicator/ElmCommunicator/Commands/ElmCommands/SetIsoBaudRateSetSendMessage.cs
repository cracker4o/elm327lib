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
using System.Globalization;

namespace ElmCommunicator.Commands.ElmCommands
{
    public enum IsoBaudRateOptions
    {
        IB10 = 10,
        IB48 = 48,
        IB96 = 96
    }

    public class SetIsoBaudRateSetSendMessage : SendMessage
    {
        public SetIsoBaudRateSetSendMessage(IsoBaudRateOptions option)
        {
            Command = "AT IB";
            Data = ((int)option).ToString(CultureInfo.InvariantCulture);
        }
    }
}