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
using Rhino.Mocks;
using UnitsNet;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class VehicleSpeedResponseTests
    {
        [SetUp]
        public void SetUp()
        {
            _response = MockRepository.GeneratePartialMock<VehicleSpeedResponse>();
        }

        private VehicleSpeedResponse _response;

        [Test]
        public void ShouldReadTheCommand()
        {
            string message = "41 0D 55";
            string expectedCommand = "410D";
            IReceiveMessage result = _response.Parse(message);
            Assert.AreEqual(expectedCommand, result.Command);
        }

        [Test]
        public void ShouldReadTheSpeed()
        {
            double expectedSpeed = 85;
            string message = "41 0D 55";
            var result = _response.Parse(message);
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedSpeed, result.As<VehicleSpeedResponse>().Speed.KilometersPerHour);
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