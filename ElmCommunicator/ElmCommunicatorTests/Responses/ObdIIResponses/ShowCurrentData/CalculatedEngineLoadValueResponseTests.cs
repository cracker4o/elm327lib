using ElmCommunicator.Commands;
using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class CalculatedEngineLoadValueResponseTests
    {
        [SetUp]
        public void SetUp()
        {
            _response = new CalculatedEngineLoadValueResponse();
        }

        private CalculatedEngineLoadValueResponse _response;

        [Test]
        public void ShouldReturnAResult()
        {
            const string message = "41 00 15";
            IReceiveMessage result = _response.Parse(message);

            Assert.IsNotNull(result);
        }

        [Test]
        public void ShouldReturnTheEngineLoadValue()
        {
            const string message = "41 00 0F";
            const int expectedEngineLoad = 15*100/255;
            var result = _response.Parse(message);

            Assert.AreEqual(expectedEngineLoad, result.As<CalculatedEngineLoadValueResponse>().EngineLoadValue);
        }
    }
}