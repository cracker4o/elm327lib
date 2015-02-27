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
    public class AdaptiveTimingControlSendMessage : SendMessage
    {
        public AdaptiveTimingControlSendMessage(string id)
        {
            this.ResponseMessage = new AdaptiveTimingControlResponseMessage();
            Command = "AT AT";

            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException("id", "The id parameter is empty.");
            }

            int idx;
            if (!int.TryParse(id, NumberStyles.Number, CultureInfo.InvariantCulture, out idx))
            {
                throw new ArgumentException("id");
            }

            if (!(idx >= 0 && idx <= 2))
            {
                throw new ArgumentOutOfRangeException("id", "The id is not between 0 and 2");
            }

            Data = id;
        }
    }
}