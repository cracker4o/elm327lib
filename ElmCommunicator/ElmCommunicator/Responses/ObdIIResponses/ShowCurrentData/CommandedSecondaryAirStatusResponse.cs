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
    /*
        1 Upstream
        2 Downstream of catalytic converter
        4 From the outside atmosphere or off
        8 Pump commanded on for diagnostics
     */
    public enum AirStatusOptions 
    {
        Default = 0,
        Upstream = 1,
        Downstream = 2,
        OutsideAtm = 4,
        PumpCommanded = 8
    }

    public class CommandedSecondaryAirStatusResponse : ResponseMessage
    {
        private AirStatusOptions? _airStatusOptions;

        public AirStatusOptions? AirStatusResponse 
        {
            get
            {
                return _airStatusOptions;
            }
        }

        public CommandedSecondaryAirStatusResponse()
        {
            _airStatusOptions = AirStatusOptions.Default;
        }

        public override string ExpectedCommand
        {
            get
            {
                return "12";
            }
        }

        public override IReceiveMessage Parse(string message)
        {
            this.Command = this.GetCommand(ref message);
            if (!this.IsValid())
            {
                return null;
            }

            this.Data = message.Substring(4);
            byte value = byte.Parse(this.Data);

            if (Enum.IsDefined(typeof(AirStatusOptions), (AirStatusOptions)value))
            {
                _airStatusOptions = (AirStatusOptions)value;
            }
            
            return this;
        }
    }
}
