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
using System.IO.Ports;
using ElmCommunicator;
using ElmCommunicator.Commands.ElmCommands;
using NUnit.Framework;
using Rhino.Mocks;

namespace ElmCommunicatorTests
{
    [TestFixture]
    internal class SenderTests
    {
        [SetUp]
        public void SetUp()
        {
            _serialPortMock = MockRepository.GenerateMock<SerialPort>();
            _senderMock = MockRepository.GeneratePartialMock<Sender>(_serialPortMock);
        }

        private SerialPort _serialPortMock;
        private Sender _senderMock;

        [Test]
        public void SendTest()
        {
            var message = new AllowLongSendMessages();

            _senderMock.Expect(a => a.Send(message))
                .Repeat.Once();

            _senderMock.Send(message);

            _senderMock.AssertWasCalled(a => a.Send(message));
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void SendTestNullMessageArgument()
        {
            AllowLongSendMessages message = null;

            _senderMock.Expect(a => a.Send(message))
                .Throw(new ArgumentNullException("message"))
                .Repeat.Once();

            _senderMock.Send(message);

            this.VerifyAllExpectations();
        }
    }
}