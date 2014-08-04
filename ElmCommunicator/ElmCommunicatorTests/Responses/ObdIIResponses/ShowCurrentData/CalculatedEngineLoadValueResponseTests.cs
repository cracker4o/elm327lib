using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class CalculatedEngineLoadValueResponseTests
    {
        private CalculatedEngineLoadValueResponse _response;

        [SetUp]
        public void SetUp()
        {
            this._response = new CalculatedEngineLoadValueResponse();
        }

        [Test]
        public void ShouldReturnAResult()
        {
            const string message = "41 00 15";
            var result = this._response.Parse(message);

            Assert.IsNotNull(result);
        }

        [Test]
        public void ShouldReturnTheEngineLoadValue()
        {
            const string message = "41 00 0F";
            const int expectedEngineLoad = 15*100/255;
            var result = (CalculatedEngineLoadValueResponse)this._response.Parse(message);

            Assert.AreEqual(expectedEngineLoad, result.EngineLoadValue);
        }
    }
}
