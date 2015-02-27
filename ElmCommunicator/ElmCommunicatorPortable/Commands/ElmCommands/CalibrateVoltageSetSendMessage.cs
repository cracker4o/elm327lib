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
using ElmCommunicatorPortable.Responses.ElmResponses;

namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class CalibrateVoltageSetSendMessage : SendMessage
    {
        /// <summary>
        ///     Calibrates the voltage. If you set voltage to 0000 it restores the default value.
        /// </summary>
        /// <param name="voltage"></param>
        public CalibrateVoltageSetSendMessage(string voltage)
        {
            this.ResponseMessage = new CommonElmResponseMessage();
            if (string.IsNullOrEmpty(voltage))
                throw new ArgumentNullException("voltage", "Please provide voltage for this command.");

            if (voltage.Length != 4)
                throw new ArgumentOutOfRangeException("voltage");

            Command = "AT CV";
            Data = voltage;
        }
    }
}