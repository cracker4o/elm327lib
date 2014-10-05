using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class FuelTrimResponseTests
    {
        private FuelTrimResponse _response;

        [Test]
        public void ShouldParseTheResponse()
        {
            string message = "41 01 55";
            double expectedTrim = -33.59375;

            _response = new FuelTrimResponse();
            _response.Parse(message);
            Assert.AreEqual(expectedTrim, _response.FuelTrim);
        }

        [Test]
        public void ShouldSetTheCommandFromTheResponse()
        {
            string message = "41 01 55";
            string expectedCommand = "4101";

            _response = new FuelTrimResponse();
            _response.Parse(message);
            Assert.AreEqual(expectedCommand, _response.Command);
        }
    }
}