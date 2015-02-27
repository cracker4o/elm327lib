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
using ElmCommunicator.Commands.ObdIICommands.ShowCurrentData;
using NUnit.Framework;

namespace ElmCommunicatorTests.Commands.ObdIICommands.ShowCurrentData
{
    [TestFixture]
    public class LongTermFuelTrimSendMessageTests
    {
        private LongTermFuelTrimSendMessage _messageToSend;

        [Test]
        public void ShouldSendBank1Command()
        {
            const string expectedMessageData = "07";
            _messageToSend = new LongTermFuelTrimSendMessage(FuelBanks.FirstFuelBank);
            Assert.AreEqual(expectedMessageData, _messageToSend.Data);
        }

        [Test]
        public void ShouldSendBank2Command()
        {
            const string expectedMessageData = "09";
            _messageToSend = new LongTermFuelTrimSendMessage(FuelBanks.SecondFuelBank);
            Assert.AreEqual(expectedMessageData, _messageToSend.Data);
        }
    }
}