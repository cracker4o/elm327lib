using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class EngineRpmResponseTests
    {
        [SetUp]
        public void SetUp()
        {
            _response = new EngineRpmResponse();
        }

        private EngineRpmResponse _response;

        [Test]
        public void ShouldCalculateTheRpmFromTheResponse()
        {
            string data = "5554";
            double expectedRpm = 5461;
            double actualRpm = _response.CalculateRpm(data);
            Assert.AreEqual(expectedRpm, actualRpm);
        }

        [Test]
        public void ShouldGetTheCommand()
        {
            string message = "41 01 55 55";
            string expectedCommand = "4101";
            _response.Parse(message);
            Assert.AreEqual(expectedCommand, _response.Command);
        }

        [Test]
        public void ShouldGetTheRpm()
        {
            string message = "41 01 55 54";
            double expectedData = 5461;
            _response.Parse(message);
            Assert.AreEqual(expectedData, _response.Rpm);
        }
    }
}