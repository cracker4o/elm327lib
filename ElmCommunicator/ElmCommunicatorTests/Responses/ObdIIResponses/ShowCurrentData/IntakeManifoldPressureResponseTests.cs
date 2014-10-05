using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;
using Rhino.Mocks;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class IntakeManifoldPressureResponseTests
    {
        [SetUp]
        public void SetUp()
        {
            _response = MockRepository.GeneratePartialMock<IntakeManifoldPressureResponse>();
        }

        private IntakeManifoldPressureResponse _response;

        [Test]
        public void ShouldGetTheData()
        {
            string expectedMessage = "41 01 0F";
            int expectedPressure = 15;
            _response.Parse(expectedMessage);
            Assert.AreEqual(expectedPressure, _response.Pressure);
        }

        [Test]
        public void ShouldSetTheCommand()
        {
            string expectedMessage = "41 01 20";
            string expectedCommand = "4101";
            _response.Parse(expectedMessage);
            Assert.AreEqual(expectedCommand, _response.Command);
        }
    }
}