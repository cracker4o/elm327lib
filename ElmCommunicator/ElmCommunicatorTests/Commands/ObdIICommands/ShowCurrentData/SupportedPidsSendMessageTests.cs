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
    public class SupportedPidsSendMessageTests
    {
        private SupportedPidsSendMessage _command;

        [Test]
        public void ShouldGenerateZeroToTwentyRangeCommand()
        {
            this._command = new SupportedPidsSendMessage(SupportedPidsRange.ZeroToTwenty);
            Assert.AreEqual("0100\r\n", this._command.ToString());
        }

        [Test]
        public void ShouldGenerateTwentyOneToFortyRangeCommand()
        {
            this._command = new SupportedPidsSendMessage(SupportedPidsRange.TwentyOneToForty);
            Assert.AreEqual("0120\r\n", this._command.ToString());
        }

        [Test]
        public void ShouldGenerateFortyOneToSixtyRangeCommand()
        {
            this._command = new SupportedPidsSendMessage(SupportedPidsRange.FortyOneToSixty);
            Assert.AreEqual("0140\r\n", this._command.ToString());
        }

        [Test]
        public void ShouldGenerateSixtyOneToEightyRangeCommand()
        {
            this._command = new SupportedPidsSendMessage(SupportedPidsRange.SixtyOneToEighty);
            Assert.AreEqual("0160\r\n", this._command.ToString());
        }

        [Test]
        public void ShouldGenerateEightyOneToHundredRangeCommand()
        {
            this._command = new SupportedPidsSendMessage(SupportedPidsRange.EightyOneToHundred);
            Assert.AreEqual("0180\r\n", this._command.ToString());
        }

        [Test]
        public void ShouldGenerateHundredAndOneTo192RangeCommand()
        {
            this._command = new SupportedPidsSendMessage(SupportedPidsRange.HundredAndOneTo192);
            Assert.AreEqual("01A0\r\n", this._command.ToString());
        }

        [Test]
        public void ShouldGenerateHundredNinetyTwoTo224RangeCommand()
        {
            this._command = new SupportedPidsSendMessage(SupportedPidsRange.HundredNinetyTwoTo224);
            Assert.AreEqual("01C0\r\n", this._command.ToString());
        }
    }
}
