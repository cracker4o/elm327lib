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
using ElmCommunicatorPortable.Commands;
using ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class CalculatedEngineLoadValueResponseTests
    {
        [SetUp]
        public void SetUp()
        {
            _response = new CalculatedEngineLoadValueResponse();
        }

        private CalculatedEngineLoadValueResponse _response;

        [Test]
        public void ShouldReturnAResult()
        {
            string message = "41 04 15";
            IReceiveMessage result = _response.Parse(message);

            Assert.IsNotNull(result);
        }

        [Test]
        public void ShouldReturnTheEngineLoadValue()
        {
            string message = "41 04 0F";
            int expectedEngineLoad = 15 * 100 / 255;
            var result = _response.Parse(message);

            Assert.AreEqual(expectedEngineLoad, result.As<CalculatedEngineLoadValueResponse>().EngineLoadValue);
        }

        [Test]
        public void ShouldReturnNullIfWrongCommand()
        {
            string message = "41 00 0F";
            var result = _response.Parse(message);

            Assert.IsNull(result);
        }
    }
}