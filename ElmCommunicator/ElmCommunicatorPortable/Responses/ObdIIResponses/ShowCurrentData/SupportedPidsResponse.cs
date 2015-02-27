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
using System.Collections;
using ElmCommunicatorPortable.Commands;

namespace ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData
{
    public class SupportedPidsResponse : ResponseMessage
    {
        private BitArray _supportedPids;

        public BitArray SupportedPids
        {
            get { return _supportedPids; }
            set { _supportedPids = value; }
        }

        public override IReceiveMessage Parse(string message)
        {
            Command = GetCommand(ref message);
            Data = message.Substring(4);
            byte[] pids = StringToByteArray(this.Data, true);
            _supportedPids = new BitArray(pids);

            return this;
        }
    }
}