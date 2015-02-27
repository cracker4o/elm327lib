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
using ElmCommunicator;
using ElmCommunicator.Responses.ElmResponses;
using NUnit.Framework;
using Rhino.Mocks;

namespace ElmCommunicatorTests
{
    [TestFixture]
    internal class ReceiverTests
    {
        [SetUp]
        public void SetUp()
        {
            _receiverMock = MockRepository.GeneratePartialMock<Receiver>();
        }

        private Receiver _receiverMock;

        [Test]
        public void ParseMessage()
        {
            string data = "DATA MESSAGE HERE"; //TODO: Set data message
            var message = new ActivityMonitorCountResponseMessage();

            Assert.NotNull(_receiverMock.Parse(data, message));
        }

        [Test]
        public void ProcessMessage()
        {
        }
    }
}