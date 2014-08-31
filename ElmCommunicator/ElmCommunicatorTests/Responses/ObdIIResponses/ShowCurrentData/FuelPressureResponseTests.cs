using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class FuelPressureResponseTests
    {
        private FuelPressureResponse _response;

        [SetUp]
        public void SetUp()
        {
            this._response = new FuelPressureResponse();
        }

        [Test]
        public void ShouldSetTheCommand()
        {
            const string message = "41 01 55";
            const string expectedCommand = "4101";
            this._response.Parse(message);
            Assert.AreEqual(expectedCommand, this._response.Command);
        }

        [Test]
        public void ShouldParseTheResponse()
        {
            const string message = "41 01 55";
            const int expectedPressure = 255;
            this._response.Parse(message);
            Assert.AreEqual(expectedPressure, this._response.Pressure);
        }
    }
}
