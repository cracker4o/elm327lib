// Copyright 2015 Tosho Toshev
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
using System;
using System.Collections;
using ElmCommunicatorPortable.Responses;
using NUnit.Framework;
using Rhino.Mocks;

namespace ElmCommunicatorTests.Responses
{
    [TestFixture]
    public class ResponseMessageTests
    {
        [SetUp]
        public void SetUp()
        {
            _responseMessage = MockRepository.GeneratePartialMock<ResponseMessage>();
        }

        private ResponseMessage _responseMessage;

        [Test]
        public void ShouldConvertBitArrayToByte()
        {
            const byte expectedByte = 1;
            byte actualByte = _responseMessage.ConvertBitsToByte(8, 3, 1);

            Assert.AreEqual(expectedByte, actualByte);
        }

        [Test]
        public void ShouldConvertHexStringToByteArray()
        {
            var expectedArray = new byte[] {0x01, 0x02};
            var expectedReverse = new byte[] {0x80, 0x40};

            byte[] actualArray = _responseMessage.StringToByteArray("01 02");
            byte[] actualReverse = _responseMessage.StringToByteArray("01 02", true);

            Assert.AreEqual(expectedArray, actualArray);
            Assert.AreEqual(expectedReverse, actualReverse);
        }

        [Test]
        public void ShouldConvertHexStringToInt()
        {
            const string hex = "3C";
            const int expectedDec = 60;

            int result = _responseMessage.HexToDec(hex);

            Assert.AreEqual(expectedDec, result);
        }

        [Test]
        public void ShouldGetTheCommandFromTheMessage()
        {
            string message = "41 00 01 02 03";
            string expectedCommand = "4100";
            string actualCommand = _responseMessage.GetCommand(ref message);


            Assert.AreEqual(expectedCommand, actualCommand);
        }

        [Test]
        public void ShouldHexToDecThrowExceptionWhenEmptyStringArgument()
        {
            var expectedException = new ArgumentNullException("hex");

            var actualException = Assert.Throws<ArgumentNullException>(() => _responseMessage.HexToDec(null));
            Assert.AreEqual(expectedException.Message, actualException.Message);
        }

        [Test]
        public void ShouldReversBitsInAByte()
        {
            const byte originalByte = 0x88;
            const byte expectedReversByte = 0x11;

            byte actualByte = _responseMessage.ReverseByte(originalByte);

            Assert.AreEqual(expectedReversByte, actualByte);
        }

        [Test]
        public void ShouldThrowAnExceptionWhenLengthLessThanOne()
        {
            var expected = new ArgumentOutOfRangeException("length");
            var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => _responseMessage.ConvertBitsToByte(8, 1, 0));
            Assert.AreEqual(expected.Message, actualException.Message);
        }

        [Test]
        public void ShouldThrowExceptionIfLengthMoreThanEight()
        {
            var expected = new ArgumentOutOfRangeException("length");
            var actualException = Assert.Throws<ArgumentOutOfRangeException>(() => _responseMessage.ConvertBitsToByte(8, 1, 9));
            Assert.AreEqual(expected.Message, actualException.Message);
        }
    }
}