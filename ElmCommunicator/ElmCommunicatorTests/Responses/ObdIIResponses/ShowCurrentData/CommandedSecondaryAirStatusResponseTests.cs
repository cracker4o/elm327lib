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
    public class CommandedSecondaryAirStatusResponseTests
    {
        private CommandedSecondaryAirStatusResponse _secondaryAirStatusResponse;

        [SetUp]
        public void SetUp()
        {
            _secondaryAirStatusResponse = new CommandedSecondaryAirStatusResponse();
        }

        [Test]
        public void ShouldSetTheCommand()
        {
            string message = "41 12 01";
            string expectedCommand = "4112";
            var response = _secondaryAirStatusResponse.Parse(message);
            Assert.AreEqual(expectedCommand, response.Command);
        }

        [Test]
        public void ShouldSetTheData()
        {
            string message = "41 12 01";
            string expectedData = "01";
            var response = _secondaryAirStatusResponse.Parse(message);
            Assert.AreEqual(expectedData, response.Data);
        }

        [Test]
        public void ShouldSetTheAirStatusOptions()
        {
            string message = "41 12 04";
            var response = _secondaryAirStatusResponse.Parse(message);
            Assert.AreNotEqual(AirStatusOptions.Default, ((CommandedSecondaryAirStatusResponse)response).AirStatusResponse);
        }

        [Test]
        public void ShouldSetTheUpstream()
        {
            string message = "41 12 01";
            var response = _secondaryAirStatusResponse.Parse(message);
            Assert.AreEqual(AirStatusOptions.Upstream, ((CommandedSecondaryAirStatusResponse)response).AirStatusResponse);
        }

        [Test]
        public void ShouldSetTheDownstream()
        {
            string message = "41 12 02";
            var response = _secondaryAirStatusResponse.Parse(message);
            Assert.AreEqual(AirStatusOptions.Downstream, ((CommandedSecondaryAirStatusResponse)response).AirStatusResponse);
        }

        [Test]
        public void ShouldSetOutsideAtm()
        {
            string message = "41 12 04";
            var response = _secondaryAirStatusResponse.Parse(message);
            Assert.AreEqual(AirStatusOptions.OutsideAtm, ((CommandedSecondaryAirStatusResponse)response).AirStatusResponse);
        }

        [Test]
        public void ShouldSetPump()
        {
            string message = "41 12 08";
            var response = _secondaryAirStatusResponse.Parse(message);
            Assert.AreEqual(AirStatusOptions.PumpCommanded, ((CommandedSecondaryAirStatusResponse)response).AirStatusResponse);
        }

        [Test]
        public void ShouldStayOnDefaultIfInvalidValue()
        {
            string message = "41 12 44";
            var response = _secondaryAirStatusResponse.Parse(message);
            Assert.AreEqual(AirStatusOptions.Default, ((CommandedSecondaryAirStatusResponse)response).AirStatusResponse);
        }
    }
}
