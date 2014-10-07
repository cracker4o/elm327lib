using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;
using Units;

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
            Pressure expectedPressure = 255*Pressure.Kilopascal;
            _response.Parse(message);
            Assert.AreEqual(expectedPressure.ConvertTo(Pressure.Kilopascal), _response.Pressure.ConvertTo(Pressure.Kilopascal));
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