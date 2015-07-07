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
using ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;
using Rhino.Mocks;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class IntakeManifoldPressureResponseTests
    {
        [SetUp]
        public void SetUp()
        {
            _response = MockRepository.GeneratePartialMock<IntakeManifoldPressureResponse>();
        }

        private IntakeManifoldPressureResponse _response;

        [Test]
        public void ShouldGetTheData()
        {
            string expectedMessage = "41 0B 0F";
            int expectedPressure = 15;
            _response.Parse(expectedMessage);
            Assert.AreEqual(expectedPressure, _response.Pressure);
        }

        [Test]
        public void ShouldSetTheCommand()
        {
            string expectedMessage = "41 0B 20";
            string expectedCommand = "410B";
            _response.Parse(expectedMessage);
            Assert.AreEqual(expectedCommand, _response.Command);
        }

        [Test]
        public void ShouldReturnNullWhenWrongCommand()
        {
            string expectedMessage = "41 01 0F";
            var result = _response.Parse(expectedMessage);
            Assert.IsNull(result);
        }
    }
}