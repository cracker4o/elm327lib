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
        [SetUp]
        public void SetUp()
        {
            _serialPortMock = MockRepository.GenerateMock<SerialPort>();
            _serialPortMock.Expect(o => o.Open())
                .Repeat.Any();
            _serialPortMock.Expect(o => o.Close())
                .Repeat.Any();

            _communicator = new SerialCommunicator(_serialPortMock);
        }

        private SerialCommunicator _communicator;

        private SerialPort _serialPortMock;

        [Test]
        public void PortDataReceived()
        {
            const string expectedMessage = "3C";
            string actualMessage = string.Empty;

            _serialPortMock.Expect(s => s.ReadExisting())
                .Repeat.Once()
                .Return(expectedMessage);

            _communicator.Sender.MessageResponse = new ActivityMonitorCountResponseMessage();
            _communicator.Receiver.OnProcessMessage += message => actualMessage = message.Data;
            _communicator.PortDataReceived(_serialPortMock, null);

            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }

    public class UnauthorizedException : Exception
    {
        private readonly string _locationY;
        private readonly string _userX;

        public UnauthorizedException(string userX, string locationY)
        {
            _userX = userX;
            _locationY = locationY;
        }

        public override string Message
        {
            get { return string.Format("User {0} is not able to access {1}", _userX, _locationY); }
        }
    }
}