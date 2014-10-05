using ElmCommunicator.Commands;
using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;
using Rhino.Mocks;

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
            string message = "41 01 55";
            string expectedCommand = "4101";
            IReceiveMessage result = _response.Parse(message);
            Assert.AreEqual(expectedCommand, result.Command);
        }

        [Test]
        public void ShouldReadTheSpeed()
        {
            int expectedSpeed = 85;
            string message = "41 01 55";
            var result = _response.Parse(message) as VehicleSpeedResponse;
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedSpeed, result.Speed);
        }
    }
}