using System.Collections;
using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;
using Rhino.Mocks;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class SupportedPidsResponseTests
    {
        [SetUp]
        public void SetUp()
        {
            _response = MockRepository.GeneratePartialMock<SupportedPidsResponse>();
        }

        private SupportedPidsResponse _response;

        [Test]
        public void ShouldFillBitArrayWithCorrectData()
        {
            const string fullCommand = "41 00 88 19 80 00";
            const string expectedMessage = "88 19 80 00";
            byte[] messageBytes = _response.StringToByteArray(expectedMessage, true);
            var expectedArray = new BitArray(messageBytes);

            _response.Parse(fullCommand);

            Assert.AreEqual(expectedArray, _response.SupportedPids);
        }
    }
}