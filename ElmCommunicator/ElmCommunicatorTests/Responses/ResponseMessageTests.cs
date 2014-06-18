using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;
using ElmCommunicator.Responses;
using NUnit.Framework;
using Rhino.Mocks;

namespace ElmCommunicatorTests.Responses
{
    [TestFixture]
    public class ResponseMessageTests
    {
        private IReceiveMessage responseMessage; 

        [SetUp]
        public void SetUp()
        {
            this.responseMessage = MockRepository.GeneratePartialMock<ResponseMessage>();
        }

        [Test]
        public void ShouldConvertHexStringToInt()
        {
            const string hex = "3C";
            const int expectedDec = 60;

            int result = this.responseMessage.HexToDec(hex);

            Assert.AreEqual(expectedDec, result);
        }

        [Test]
        public void ShouldHexToDecThrowExceptionWhenEmptyStringArgument()
        {
            var expectedException = new ArgumentNullException("hex");

            var actualException = Assert.Throws<ArgumentNullException>(() => this.responseMessage.HexToDec(null));
            Assert.AreEqual(expectedException.Message, actualException.Message);
        }
    }
}
