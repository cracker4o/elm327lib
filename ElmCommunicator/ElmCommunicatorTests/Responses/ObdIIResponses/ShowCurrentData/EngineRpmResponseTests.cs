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
using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;
using UnitsNet;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class EngineRpmResponseTests
    {
        [SetUp]
        public void SetUp()
        {
            _response = new EngineRpmResponse();
        }

        private EngineRpmResponse _response;

        [Test]
        public void ShouldCalculateTheRpmFromTheResponse()
        {
            string data = "5554";
            RotationalSpeed expectedRpm = RotationalSpeed.FromRevolutionsPerMinute(5461);
            RotationalSpeed actualRpm = _response.CalculateRpm(data);
            Assert.AreEqual(expectedRpm, actualRpm);
        }

        [Test]
        public void ShouldGetTheCommand()
        {
            string message = "41 01 55 55";
            string expectedCommand = "4101";
            _response.Parse(message);
            Assert.AreEqual(expectedCommand, _response.Command);
        }

        [Test]
        public void ShouldGetTheRpm()
        {
            string message = "41 01 55 54";
            RotationalSpeed expectedData = RotationalSpeed.FromRevolutionsPerMinute(5461);
            _response.Parse(message);
            Assert.AreEqual(expectedData, _response.Rpm);
        }
    }
}