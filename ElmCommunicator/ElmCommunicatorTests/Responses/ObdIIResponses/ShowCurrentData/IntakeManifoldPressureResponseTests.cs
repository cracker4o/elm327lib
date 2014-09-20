using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;
using Rhino.Mocks;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class IntakeManifoldPressureResponseTests
    {
        private IntakeManifoldPressureResponse _response;

        [SetUp]
        public void SetUp()
        {
            this._response = MockRepository.GeneratePartialMock<IntakeManifoldPressureResponse>();
        }

        [Test]
        public void ShouldSetTheCommand()
        {
            string expectedMessage = "41 01 20";
            string expectedCommand = "4101";
            this._response.Parse(expectedMessage);
            Assert.AreEqual(expectedCommand, this._response.Command);
        }

        [Test]
        public void ShouldGetTheData()
        {
            string expectedMessage = "41 01 0F";
            int expectedPressure = 15;
            this._response.Parse(expectedMessage);
            Assert.AreEqual(expectedPressure, this._response.Pressure);
        }
    }
}
