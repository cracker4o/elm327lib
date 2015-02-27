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
using ElmCommunicator.Commands;
using NUnit.Framework;
using Rhino.Mocks;

namespace ElmCommunicatorTests.Commands
{
    [TestFixture]
    public class SendMessageTests
    {
        [SetUp]
        public void SetUp()
        {
            _sendMessagePartialMock = MockRepository.GeneratePartialMock<SendMessage>();
        }

        private SendMessage _sendMessagePartialMock;

        [Test]
        public void CheckValidHexNumberByteShould()
        {
            string expectedHexNumber = "1D";
            bool result = _sendMessagePartialMock.CheckValidHexNumberByte(expectedHexNumber);

            Assert.AreEqual(true, result);

            expectedHexNumber = "MS";
            result = _sendMessagePartialMock.CheckValidHexNumberByte(expectedHexNumber);

            Assert.AreEqual(false, result);
        }

        [Test]
        public void ToStringShould()
        {
            const string startTermination = "11";
            const string command = "CMD";
            const string data = "123";
            const string endTermination = "\r\n";
            string expectedResponse = string.Format("{0}{1}{2}{3}", startTermination, command, data, endTermination);

            _sendMessagePartialMock.StartTermination = startTermination;
            _sendMessagePartialMock.Command = command;
            _sendMessagePartialMock.Data = data;
            _sendMessagePartialMock.EndTermination = endTermination;

            Assert.AreEqual(expectedResponse, _sendMessagePartialMock.ToString());
        }
    }
}