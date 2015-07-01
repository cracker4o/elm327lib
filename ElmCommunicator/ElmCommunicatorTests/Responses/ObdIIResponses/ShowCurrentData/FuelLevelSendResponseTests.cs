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

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class FuelLevelSendResponseTests
    {
        private FuelLevelResponse _response;

        [SetUp]
        public void SetUp()
        {
            _response = MockRepository.GeneratePartialMock<FuelLevelResponse>();
        }

        [Test]
        public void ShouldReadTheCommand()
        {
            string message = "41 2F 55";
            string expectedCommand = "412F";
            IReceiveMessage result = _response.Parse(message);
            Assert.AreEqual(expectedCommand, result.Command);
        }

        [Test]
        public void ShouldReadTheFuelLevel()
        {
            double expectedLevel = 85;
            string message = "41 2F 55";
            var result = _response.Parse(message);
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedLevel, result.As<FuelLevelResponse>().FuelLevel);
        }

        [Test]
        public void ShouldReturnNullWhenWrongCommand()
        {
            string message = "41 0A 55";
            var result = _response.Parse(message);
            Assert.IsNull(result);
        }
    }
}
