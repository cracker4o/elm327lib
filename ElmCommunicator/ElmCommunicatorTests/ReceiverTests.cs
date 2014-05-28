using ElmCommunicator;
using ElmCommunicator.Responses.ElmResponses;
using NUnit.Framework;
using Rhino.Mocks;

namespace ElmCommunicatorTests
{
    [TestFixture]
    class ReceiverTests
    {
        private Receiver _receiverMock;

        [SetUp]
        public void SetUp()
        {
            this._receiverMock = MockRepository.GeneratePartialMock<Receiver>();
        }

        [Test]
        public void ProcessMessage()
        {

        }

        [Test]
        public void ParseMessage()
        {
            string data = "DATA MESSAGE HERE"; //TODO: Set data message
            var message = new ActivityMonitorCountResponseMessage();

            Assert.NotNull(this._receiverMock.Parse(data, message));
        }
    }
}
