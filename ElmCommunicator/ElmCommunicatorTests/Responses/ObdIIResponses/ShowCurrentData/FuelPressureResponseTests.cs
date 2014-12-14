using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;
using UnitsNet;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class FuelPressureResponseTests
    {
        [SetUp]
        public void SetUp()
        {
            _response = new FuelPressureResponse();
        }

        private FuelPressureResponse _response;

        [Test]
        public void ShouldParseTheResponse()
        {
            const string message = "41 01 55";
            Pressure expectedPressure = Pressure.FromKilopascals(255);
            _response.Parse(message);
            Assert.AreEqual(expectedPressure.Kilopascals, _response.Pressure.Kilopascals);
        }

        [Test]
        public void ShouldSetTheCommand()
        {
            const string message = "41 01 55";
            const string expectedCommand = "4101";
            _response.Parse(message);
            Assert.AreEqual(expectedCommand, _response.Command);
        }
    }
}