using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;
using Rhino.Mocks;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class SupportedPidsResponseMessageTests
    {
        private SupportedPidsResponseMessage _response;

        [SetUp]
        public void SetUp()
        {
            this._response = MockRepository.GeneratePartialMock<SupportedPidsResponseMessage>();
        }

        [Test]
        public void ShouldFillBitArrayWithCorrectData()
        {
            const string fullCommand = "41 00 88 19 80 00";
            const string expectedMessage = "88 19 80 00";
            var messageBytes = this._response.StringToByteArray(expectedMessage, true);
            var expectedArray = new BitArray(messageBytes);
            
            this._response.Parse(fullCommand);

            Assert.AreEqual(expectedArray, this._response.SupportedPids);
        }
    }
}
