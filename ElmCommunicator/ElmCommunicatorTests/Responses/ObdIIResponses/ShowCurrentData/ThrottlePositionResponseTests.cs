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

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class ThrottlePositionResponseTests
    {
        private ThrottlePositionResponse _response;

        [SetUp]
        public void SetUp()
        {
            _response = new ThrottlePositionResponse();
        }

        [Test]
        public void ShouldSetTheCommand()
        {
            string expectedCommand = "4111";
            _response.Parse("41 11 08");
            Assert.AreEqual(expectedCommand, _response.Command);
        }

        [Test]
        public void ShouldSetTheDate()
        {
            string expectedData = "08";
            _response.Parse("41 11 08");
            Assert.AreEqual(expectedData, _response.Data);
        }

        [Test]
        public void ShouldSetTheThrottlePosition()
        {
            int expectedThrottle = 8*100/255;
            _response.Parse("41 11 08");
            Assert.AreEqual(expectedThrottle, _response.ThrottlePosition);
        }

        [Test]
        public void ShouldReturnNullWhenWrongCommand()
        {
            var result = _response.Parse("41 19 08");
            Assert.IsNull(result);
        }
    }
}
