using ElmCommunicator.Commands;
using NUnit.Framework;
using Rhino.Mocks;

namespace ElmCommunicatorTests.Commands
{
    [TestFixture]
    public class SendMessageTests
    {
        [SetUp]
        public void SetUp()
        {
            _sendMessagePartialMock = MockRepository.GeneratePartialMock<SendMessage>();
        }

        private SendMessage _sendMessagePartialMock;

        [Test]
        public void CheckValidHexNumberByteShould()
        {
            string expectedHexNumber = "1D";
            bool result = _sendMessagePartialMock.CheckValidHexNumberByte(expectedHexNumber);

            Assert.AreEqual(true, result);

            expectedHexNumber = "MS";
            result = _sendMessagePartialMock.CheckValidHexNumberByte(expectedHexNumber);

            Assert.AreEqual(false, result);
        }

        [Test]
        public void ToStringShould()
        {
            const string startTermination = "11";
            const string command = "CMD";
            const string data = "123";
            const string endTermination = "\r\n";
            string expectedResponse = string.Format("{0}{1}{2}{3}", startTermination, command, data, endTermination);

            _sendMessagePartialMock.StartTermination = startTermination;
            _sendMessagePartialMock.Command = command;
            _sendMessagePartialMock.Data = data;
            _sendMessagePartialMock.EndTermination = endTermination;

            Assert.AreEqual(expectedResponse, _sendMessagePartialMock.ToString());
        }
    }
}