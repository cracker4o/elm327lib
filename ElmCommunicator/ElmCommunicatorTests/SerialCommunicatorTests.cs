using System;
using System.IO.Ports;
using ElmCommunicator;
using ElmCommunicator.Responses.ElmResponses;
using NUnit.Framework;
using Rhino.Mocks;

namespace ElmCommunicatorTests
{
    [TestFixture]
    public class SerialCommunicatorTests
    {
        private SerialCommunicator _communicator;

        private SerialPort _serialPortMock;

        [SetUp]
        public void SetUp()
        {
            this._serialPortMock = MockRepository.GenerateMock<SerialPort>();
            this._serialPortMock.Expect(o => o.Open())
                .Repeat.Any();
            this._serialPortMock.Expect(o => o.Close())
                .Repeat.Any();

            this._communicator = new SerialCommunicator(this._serialPortMock);
        }

        [Test]
        public void PortDataReceived()
        {
            string expectedMessage = "My command here";
            string actualMessage = string.Empty;

            this._serialPortMock.Expect(s => s.ReadExisting())
                .Repeat.Once()
                .Return(actualMessage);

            this._communicator.Sender.LastMessage = new ActivityMonitorCountResponseMessage();
            this._communicator.Receiver.OnProcessMessage += message => expectedMessage = message.ToString();
            this._communicator.PortDataReceived(this._serialPortMock, null);

            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
