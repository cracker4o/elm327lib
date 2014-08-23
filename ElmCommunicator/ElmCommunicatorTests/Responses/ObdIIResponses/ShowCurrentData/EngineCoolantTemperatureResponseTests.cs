using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;
using Rhino.Mocks;
using Units;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class EngineCoolantTemperatureResponseTests
    {
        private const string Message = "41 00 3C";

        private EngineCoolantTemperatureResponse _response;

        [SetUp]
        public void SetUp()
        {
            this._response = MockRepository.GeneratePartialMock<EngineCoolantTemperatureResponse>();
        }

        [Test]
        public void ShouldGetTheCommand()
        {
            const string expectedCommand = "4100";
            var response = this._response.Parse(Message);
            Assert.AreEqual(expectedCommand, response.Command);
            
        }

        [Test]
        public void ShouldParseTheReceivedMessage()
        {
            const string expectedCommand = "4100";
            const float expectedTemperature = 20;
            this._response.Parse(Message);
            Assert.AreEqual(expectedCommand, this._response.Command);
            Assert.AreEqual(expectedTemperature, this._response.Temperature.ConvertTo(Temperature.DegreeCelsius));
        }
    }
}
