using System;
using System.IO.Ports;
using ElmCommunicator;
using ElmCommunicator.Commands.ElmCommands;
using NUnit.Framework;
using Rhino.Mocks;

namespace ElmCommunicatorTests
{
    [TestFixture]
    internal class SenderTests
    {
        [SetUp]
        public void SetUp()
        {
            _serialPortMock = MockRepository.GenerateMock<SerialPort>();
            _senderMock = MockRepository.GeneratePartialMock<Sender>(_serialPortMock);
        }

        private SerialPort _serialPortMock;
        private Sender _senderMock;

        [Test]
        public void SendTest()
        {
            var message = new AllowLongSendMessages();

            _senderMock.Expect(a => a.Send(message))
                .Repeat.Once();

            _senderMock.Send(message);

            _senderMock.AssertWasCalled(a => a.Send(message));
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void SendTestNullMessageArgument()
        {
            AllowLongSendMessages message = null;

            _senderMock.Expect(a => a.Send(message))
                .Throw(new ArgumentNullException("message"))
                .Repeat.Once();

            _senderMock.Send(message);

            this.VerifyAllExpectations();
        }
    }
}