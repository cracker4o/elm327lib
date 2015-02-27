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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;
using UnitsNet;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class BarometricPressureResponseTests
    {
        private BarometricPressureResponse _response;

        [SetUp]
        public void SetUp()
        {
            _response = new BarometricPressureResponse();
        }

        [Test]
        public void ShouldSetThePressure()
        {
            string message = "41 33 10";
            Pressure expectedPressure = Pressure.FromKilopascals(0x10);
            var result = _response.Parse(message);
            Assert.AreEqual(expectedPressure, result.As<BarometricPressureResponse>().Pressure);
        }
    }
}
