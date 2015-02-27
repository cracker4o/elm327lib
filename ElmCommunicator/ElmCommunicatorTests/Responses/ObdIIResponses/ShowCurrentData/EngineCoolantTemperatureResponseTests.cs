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
using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;
using Rhino.Mocks;
using UnitsNet;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class EngineCoolantTemperatureResponseTests
    {
        [SetUp]
        public void SetUp()
        {
            _response = MockRepository.GeneratePartialMock<EngineCoolantTemperatureResponse>();
        }

        private const string Message = "41 00 3C";

        private EngineCoolantTemperatureResponse _response;

        [Test]
        public void ShouldGetTheCommand()
        {
            const string expectedCommand = "4100";
            IReceiveMessage response = _response.Parse(Message);
            Assert.AreEqual(expectedCommand, response.Command);
        }

        [Test]
        public void ShouldParseTheReceivedMessage()
        {
            const string expectedCommand = "4100";
            const float expectedTemperature = 20;
            _response.Parse(Message);
            Assert.AreEqual(expectedCommand, _response.Command);
            Assert.AreEqual(expectedTemperature, _response.Temperature.DegreesCelsius);
        }
    }
}