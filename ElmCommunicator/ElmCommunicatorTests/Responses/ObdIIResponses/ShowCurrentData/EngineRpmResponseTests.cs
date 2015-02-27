using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;
using UnitsNet;

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
            RotationalSpeed expectedRpm = RotationalSpeed.FromRevolutionsPerMinute(5461);
            RotationalSpeed actualRpm = _response.CalculateRpm(data);
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
            RotationalSpeed expectedData = RotationalSpeed.FromRevolutionsPerMinute(5461);
            _response.Parse(message);
            Assert.AreEqual(expectedData, _response.Rpm);
        }
    }
}