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
    public class FuelTrimResponseTests
    {
        private FuelTrimResponse _response;

        [Test]
        public void ShouldParseTheResponse()
        {
            string message = "41 07 55";
            double expectedTrim = -33.59375;

            _response = new FuelTrimResponse();
            _response.Parse(message);
            Assert.AreEqual(expectedTrim, _response.FuelTrim);
        }

        [Test]
        public void ShouldSetTheCommandFromTheResponse()
        {
            string message = "41 09 55";
            string expectedCommand = "4109";

            _response = new FuelTrimResponse();
            _response.Parse(message);
            Assert.AreEqual(expectedCommand, _response.Command);
        }

        [Test]
        public void ShouldReturnNullWhenWrongCommand()
        {
            string message = "41 01 55";

            _response = new FuelTrimResponse();
            var result = _response.Parse(message);
            Assert.IsNull(result);
        }
    }
}