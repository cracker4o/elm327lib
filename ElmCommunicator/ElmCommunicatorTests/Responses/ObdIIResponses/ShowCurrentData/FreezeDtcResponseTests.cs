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
using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class FreezeDtcResponseTests
    {
        [SetUp]
        public void SetUp()
        {
            _freezeDtc = new FreezeDtcResponse();
        }

        private FreezeDtcResponse _freezeDtc;

        [Test]
        public void ShouldReceiveTwoByteResult()
        {
            string messageResponse = "43 00 03 09";
            byte expected = 3;
            byte second = 9;
            _freezeDtc.Parse(messageResponse);
            Assert.AreEqual(expected, _freezeDtc.ReceivedBytes[0]);
            Assert.AreEqual(second, _freezeDtc.ReceivedBytes[1]);
        }
    }
}