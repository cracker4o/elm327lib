using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;

using NUnit.Framework;

using UnitsNet;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class DistanceTravelledWithMilResponseTests
    {
        private DistanceTravelledWithMilResponse _response;

        [SetUp]
        public void SetUp()
        {
            _response = new DistanceTravelledWithMilResponse();
        }

        [Test]
        public void ShouldSetTheCommand()
        {
            string message = "41 21 0A 0A";
            _response.Parse(message);
            Assert.AreEqual("4121", _response.Command);
        }

        [Test]
        public void ShouldSetTheData()
        {
            string message = "41 21 0A 0A";
            _response.Parse(message);
            Assert.AreEqual("0A0A", _response.Data);

        }

        [Test]
        public void ShouldSetTheDistance()
        {
            string message = "41 21 0A 0A";
            var response = _response.Parse(message);
            Assert.AreEqual(Length.FromKilometers(2570), response.As<DistanceTravelledWithMilResponse>().Distance);
        }
    }
}
