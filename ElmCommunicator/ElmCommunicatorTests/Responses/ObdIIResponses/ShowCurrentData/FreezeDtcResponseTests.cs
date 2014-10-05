using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class FreezeDtcResponseTests
    {
        [SetUp]
        public void SetUp()
        {
            _freezeDtc = new FreezeDtcResponse();
        }

        private FreezeDtcResponse _freezeDtc;

        [Test]
        public void ShouldReceiveTwoByteResult()
        {
            string messageResponse = "43 00 03 09";
            byte expected = 3;
            byte second = 9;
            _freezeDtc.Parse(messageResponse);
            Assert.AreEqual(expected, _freezeDtc.ReceivedBytes[0]);
            Assert.AreEqual(second, _freezeDtc.ReceivedBytes[1]);
        }
    }
}