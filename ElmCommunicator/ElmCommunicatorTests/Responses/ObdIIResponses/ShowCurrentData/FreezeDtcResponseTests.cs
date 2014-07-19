using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class FreezeDtcResponseTests
    {
        private FreezeDtcResponse _freezeDtc;

        [SetUp]
        public void SetUp()
        {
            this._freezeDtc = new FreezeDtcResponse();
        }

        [Test]
        public void ShouldReceiveTwoByteResult()
        {
            string messageResponse = "43 00 03 09";
            byte expected = 3;
            byte second = 9;
            this._freezeDtc.Parse(messageResponse);
            Assert.AreEqual(expected, this._freezeDtc.ReceivedBytes[0]);
            Assert.AreEqual(second, this._freezeDtc.ReceivedBytes[1]);
        }

    }
}
