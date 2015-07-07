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
    public class FuelSystemStatusResponseTests
    {
        [SetUp]
        public void SetUp()
        {
            _response = new FuelSystemStatusResponse();
        }

        private FuelSystemStatusResponse _response;

        [Test]
        public void ShouldGetTheTwoBytesFromTheMessage()
        {
            const string message = "41 03 02 04";
            var result = _response.Parse(message);

            Assert.AreEqual(FuelSystemStatus.ClosedLoopOxySensor, result.As<FuelSystemStatusResponse>().FuelSystemOne);
            Assert.AreEqual(FuelSystemStatus.OpenLoopEngineLoad, result.As<FuelSystemStatusResponse>().FuelSystemTwo);
        }

        [Test]
        public void ShouldReturnAResult()
        {
            const string message = "41 03 02 04";
            var result = _response.Parse(message).As<FuelSystemStatusResponse>();

            Assert.IsNotNull(result);
        }

        [Test]
        public void ShouldReturnNullWhenWrongCommand()
        {
            const string message = "41 01 02 04";
            var result = _response.Parse(message);

            Assert.IsNull(result);
        }
    }
}