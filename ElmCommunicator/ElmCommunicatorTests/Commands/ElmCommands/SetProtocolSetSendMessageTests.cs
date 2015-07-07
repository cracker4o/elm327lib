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
using ElmCommunicatorPortable.Commands.ElmCommands;
using NUnit.Framework;

namespace ElmCommunicatorTests.Commands.ElmCommands
{
    public class SetProtocolSetSendMessageTests
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void ShouldContainOnlyOneLetterInDataField()
        {
            var command = new SetProtocolSetSendMessage(11);
            Assert.AreEqual(1, command.Data.Length);
        }

        [Test]
        public void ShouldSetDoubleZerosForDataWhenTheResetIsTrue()
        {
            var command = new SetProtocolSetSendMessage(0, true);
            Assert.AreEqual("00", command.Data);
        }
    }
}