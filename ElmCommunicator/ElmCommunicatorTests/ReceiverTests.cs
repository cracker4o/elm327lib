using ElmCommunicator;
using ElmCommunicator.Responses.ElmResponses;
using NUnit.Framework;
using Rhino.Mocks;

namespace ElmCommunicatorTests
{
    [TestFixture]
    internal class ReceiverTests
    {
        [SetUp]
        public void SetUp()
        {
            _receiverMock = MockRepository.GeneratePartialMock<Receiver>();
        }

        private Receiver _receiverMock;

        [Test]
        public void ParseMessage()
        {
            string data = "DATA MESSAGE HERE"; //TODO: Set data message
            var message = new ActivityMonitorCountResponseMessage();

            Assert.NotNull(_receiverMock.Parse(data, message));
        }

        [Test]
        public void ProcessMessage()
        {
        }
    }
}