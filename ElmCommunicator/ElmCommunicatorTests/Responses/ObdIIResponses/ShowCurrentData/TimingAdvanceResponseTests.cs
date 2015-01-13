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
    public class TimingAdvanceResponseTests
    {
        private TimingAdvanceResponse _timingAdvanceResponse;

        [SetUp]
        public void SetUp()
        {
            _timingAdvanceResponse = new TimingAdvanceResponse();
        }

        [Test]
        public void ShouldSetTheCommand()
        {
            string message = "41 0E 45";
            string expectedCommand = "410E";
            var result = _timingAdvanceResponse.Parse(message);
            Assert.AreEqual(expectedCommand, result.Command);
        }

        [Test]
        public void ShouldSetTheData()
        {
            string message = "41 0E 45";
            string expectedData = "45";
            var result = _timingAdvanceResponse.Parse(message);
            Assert.AreEqual(expectedData, result.Data);
        }

        [Test]
        public void ShouldSetTheTimingAdvanceProperty()
        {
            string message = "41 0E 45";
            float expectedTimingAdvance = (0x45 - 128f) / 2;
            var result = _timingAdvanceResponse.Parse(message);
            Assert.AreEqual(expectedTimingAdvance, ((TimingAdvanceResponse)result).TimingAdvance);
        }
    }
}
