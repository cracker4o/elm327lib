using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ElmCommunicator.Commands;
using Rhino.Mocks;

namespace ElmCommunicatorTests.Commands
{
    [TestFixture]
    public class SendMessageTests
    {
        private SendMessage _sendMessagePartialMock;

        [SetUp]
        public void SetUp()
        {
            this._sendMessagePartialMock = MockRepository.GeneratePartialMock<SendMessage>();
        }

        [Test]
        public void ToStringShould()
        {
            const string startTermination = "11";
            const string command = "CMD";
            const string data = "123";
            const string endTermination = "\r\n";
            var expectedResponse = string.Format("{0}{1}{2}{3}", startTermination, command, data, endTermination);

            this._sendMessagePartialMock.StartTermination = startTermination;
            this._sendMessagePartialMock.Command = command;
            this._sendMessagePartialMock.Data = data;
            this._sendMessagePartialMock.EndTermination = endTermination;
            
            Assert.AreEqual(expectedResponse, this._sendMessagePartialMock.ToString());
        }

        [Test]
        public void CheckValidHexNumberByteShould()
        {
            string expectedHexNumber = "1D";
            bool result = this._sendMessagePartialMock.CheckValidHexNumberByte(expectedHexNumber);
            
            Assert.AreEqual(true, result);

            expectedHexNumber = "MS";
            result = this._sendMessagePartialMock.CheckValidHexNumberByte(expectedHexNumber);

            Assert.AreEqual(false, result);
        }
    }
}
