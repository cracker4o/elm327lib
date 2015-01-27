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
            var result = (IntakeAirTemperatureResponse)this._response.Parse(message);
            Assert.AreEqual(expectedTemperature, result.Temperature);
        }
    }
}
