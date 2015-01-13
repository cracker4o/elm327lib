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
    public class ThrottlePositionResponseTests
    {
        private ThrottlePositionResponse _response;

        [SetUp]
        public void SetUp()
        {
            _response = new ThrottlePositionResponse();
        }

        [Test]
        public void ShouldSetTheCommand()
        {
            string expectedCommand = "4301";
            _response.Parse("43 01 08");
            Assert.AreEqual(expectedCommand, _response.Command);
        }

        [Test]
        public void ShouldSetTheDate()
        {
            string expectedData = "08";
            _response.Parse("43 01 08");
            Assert.AreEqual(expectedData, _response.Data);
        }

        [Test]
        public void ShouldSetTheThrottlePosition()
        {
            int expectedThrottle = 8*100/255;
            _response.Parse("43 01 08");
            Assert.AreEqual(expectedThrottle, _response.ThrottlePosition);
        }
    }
}
