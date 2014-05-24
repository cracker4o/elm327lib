using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator;
using ElmCommunicator.Commands.ElmCommands;
using NUnit.Framework;
using Rhino.Mocks;

namespace ElmCommunicatorTests
{
    [TestFixture]
    class SenderTests
    {
        private SerialPort _serialPortMock;
        private Sender _senderMock;

        [SetUp]
        public void SetUp()
        {
            this._serialPortMock = MockRepository.GenerateMock<SerialPort>();
            this._senderMock = MockRepository.GeneratePartialMock<Sender>(_serialPortMock);
        }

        [Test]
        public void SendTest()
        {
            var message = new AllowLongSendMessages();

            this._senderMock.Expect(a => a.Send(message))
                .Repeat.Once();

            this._senderMock.Send(message);

            this._senderMock.AssertWasCalled(a => a.Send(message));
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SendTestNullMessageArgument()
        {
            AllowLongSendMessages message = null;

            this._senderMock.Expect(a => a.Send(message))
                .Throw(new ArgumentNullException("message"))
                .Repeat.Once();

            this._senderMock.Send(message);

            this.VerifyAllExpectations();
        }
    }
}
