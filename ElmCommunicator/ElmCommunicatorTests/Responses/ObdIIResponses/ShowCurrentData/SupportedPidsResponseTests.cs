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
using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;
using Rhino.Mocks;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class SupportedPidsResponseTests
    {
        [SetUp]
        public void SetUp()
        {
            _response = MockRepository.GeneratePartialMock<SupportedPidsResponse>();
        }

        private SupportedPidsResponse _response;

        [Test]
        public void ShouldFillBitArrayWithCorrectData()
        {
            const string fullCommand = "41 00 88 19 80 00";
            const string expectedMessage = "88 19 80 00";
            byte[] messageBytes = _response.StringToByteArray(expectedMessage, true);
            var expectedArray = new BitArray(messageBytes);

            _response.Parse(fullCommand);

            Assert.AreEqual(expectedArray, _response.SupportedPids);
        }
    }
}