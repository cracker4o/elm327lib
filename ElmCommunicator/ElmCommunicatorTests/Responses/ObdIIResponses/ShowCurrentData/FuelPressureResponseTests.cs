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
using UnitsNet;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class FuelPressureResponseTests
    {
        [SetUp]
        public void SetUp()
        {
            _response = new FuelPressureResponse();
        }

        private FuelPressureResponse _response;

        [Test]
        public void ShouldParseTheResponse()
        {
            const string message = "41 0A 55";
            Pressure expectedPressure = Pressure.FromKilopascals(255);
            _response.Parse(message);
            Assert.AreEqual(expectedPressure.Kilopascals, _response.Pressure.Kilopascals);
        }

        [Test]
        public void ShouldSetTheCommand()
        {
            const string message = "41 0A 55";
            const string expectedCommand = "410A";
            _response.Parse(message);
            Assert.AreEqual(expectedCommand, _response.Command);
        }

        [Test]
        public void ShouldReturnNullWhenWrongCommand()
        {
            const string message = "41 01 55";
            
            var result = _response.Parse(message);
            Assert.IsNull(result);
        }
    }
}