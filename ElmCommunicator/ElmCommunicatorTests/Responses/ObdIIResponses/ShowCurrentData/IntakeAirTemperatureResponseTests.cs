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
    public class IntakeAirTemperatureResponseTests
    {
        private IntakeAirTemperatureResponse _response;

        [Test]
        public void SetUp()
        {
            _response = new IntakeAirTemperatureResponse();
        }

        [Test]
        public void ShouldSetTheCommand()
        {
            string message = "41 0F 50";
            var result = this._response.Parse(message);
            Assert.AreEqual(result.Command, "410F");
        }

        [Test]
        public void ShouldSetTheData()
        {
            string message = "41 0F 50";
            var result = this._response.Parse(message);
            Assert.AreEqual(result.Data, "50");
        }

        [Test]
        public void ShouldSetTheTemperature()
        {
            string message = "41 0F 50";
            var expectedTemperature = Temperature.FromDegreesCelsius(40);
            var result = this._response.Parse(message);
            Assert.AreEqual(expectedTemperature, result.As<IntakeAirTemperatureResponse>().Temperature);
        }

        [Test]
        public void ShouldReturnNullWhenWrongCommand()
        {
            string message = "41 0A 50";
            var result = this._response.Parse(message);
            Assert.IsNull(result);
        }
    }
}
