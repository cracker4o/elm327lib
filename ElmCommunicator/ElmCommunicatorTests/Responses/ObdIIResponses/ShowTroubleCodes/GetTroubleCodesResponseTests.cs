using System;
using ElmCommunicatorPortable.Responses.ObdIIResponses.ShowTroubleCodes;
using NUnit.Framework;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowTroubleCodes
{
    [TestFixture]
    public class GetTroubleCodesResponseTests
    {
        private GetTroubleCodesResponse _response;

        [SetUp]
        public void SetUp()
        {
            _response = new GetTroubleCodesResponse();
        }

        [Test]
        public void ShouldGetAnArrayOfDtcCodes()
        {
            int expectedCount = 3;
            var message = "43 01 03 01 04 01 05";
            var result = _response.GetDtcFromString(message);
            
            Assert.AreEqual(expectedCount, result.Count);
            Assert.AreEqual("0103", result[0]);
            Assert.AreEqual("0104", result[1]);
            Assert.AreEqual("0105", result[2]);
        }

        [Test]
        public void ShouldProcessADtcRawResultToDtc()
        {
            var expectedDtc = new DtcCode
            {
                CodeType = TroubleCodeType.PowerTrain,
                CodeBody = "0103"
            };
            var rawDtc = "0103";
            var result = _response.ProcessDtc(rawDtc);

            Assert.AreEqual(expectedDtc.ToString(), result.ToString());
        }

        //[Test]
        //public void ShouldProcessABodyTroubleCodeToDtc()
        //{
        //    var expectedDtc = new DtcCode
        //    {
        //        CodeType = TroubleCodeType.Body,
        //        CodeBody = "08B"
        //    };
        //}
    }
}
