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
