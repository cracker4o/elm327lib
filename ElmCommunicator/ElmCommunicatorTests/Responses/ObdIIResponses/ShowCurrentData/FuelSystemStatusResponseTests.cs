using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class FuelSystemStatusResponseTests
    {
        [SetUp]
        public void SetUp()
        {
            _response = new FuelSystemStatusResponse();
        }

        private FuelSystemStatusResponse _response;

        [Test]
        public void ShouldGetTheTwoBytesFromTheMessage()
        {
            const string message = "41 00 02 04";
            var result = _response.Parse(message);

            Assert.AreEqual(FuelSystemStatus.ClosedLoopOxySensor, result.As<FuelSystemStatusResponse>().FuelSystemOne);
            Assert.AreEqual(FuelSystemStatus.OpenLoopEngineLoad, result.As<FuelSystemStatusResponse>().FuelSystemTwo);
        }

        [Test]
        public void ShouldReturnAResult()
        {
            const string message = "41 00 02 04";
            var result = _response.Parse(message).As<FuelSystemStatusResponse>();

            Assert.IsNotNull(result);
        }
    }
}