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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class TimingAdvanceResponse : ResponseMessage
    {
        public override string ExpectedCommand
        {
            get
            {
                return "0E";
            }
        }

        public override IReceiveMessage Parse(string message)
        {
            this.Command = this.GetCommand(ref message);
            if(!this.IsValid())
            {
                return null;
            }

            this.Data = message.Substring(4);
            TimingAdvance = (this.HexToDec(this.Data) - 128f) / 2;
            return this;
        }

        public double TimingAdvance { get; private set; }
    }
}
