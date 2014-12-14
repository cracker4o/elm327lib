using ElmCommunicator.Commands;
using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;
using Rhino.Mocks;
using UnitsNet;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class EngineCoolantTemperatureResponseTests
    {
        [SetUp]
        public void SetUp()
        {
            _response = MockRepository.GeneratePartialMock<EngineCoolantTemperatureResponse>();
        }

        private const string Message = "41 00 3C";

        private EngineCoolantTemperatureResponse _response;

        [Test]
        public void ShouldGetTheCommand()
        {
            const string expectedCommand = "4100";
            IReceiveMessage response = _response.Parse(Message);
            Assert.AreEqual(expectedCommand, response.Command);
        }

        [Test]
        public void ShouldParseTheReceivedMessage()
        {
            const string expectedCommand = "4100";
            const float expectedTemperature = 20;
            _response.Parse(Message);
            Assert.AreEqual(expectedCommand, _response.Command);
            Assert.AreEqual(expectedTemperature, _response.Temperature.DegreesCelsius);
        }
    }
}