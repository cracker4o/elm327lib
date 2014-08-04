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
    public class FuelSystemStatusResponseTests
    {
        private FuelSystemStatusResponse _response;

        [SetUp]
        public void SetUp()
        {
            this._response = new FuelSystemStatusResponse();
        }

        [Test]
        public void ShouldReturnAResult()
        {
            const string message = "41 00 02 04";
            var result = this._response.Parse(message) as FuelSystemStatusResponse;
            
            Assert.IsNotNull(result);
        }

        [Test]
        public void ShouldGetTheTwoBytesFromTheMessage()
        {
            const string message = "41 00 02 04";
            var result = (FuelSystemStatusResponse)this._response.Parse(message);

            Assert.AreEqual(FuelSystemStatus.ClosedLoopOxySensor, result.FuelSystemOne);
            Assert.AreEqual(FuelSystemStatus.OpenLoopEngineLoad, result.FuelSystemTwo);
        }
    }
}
