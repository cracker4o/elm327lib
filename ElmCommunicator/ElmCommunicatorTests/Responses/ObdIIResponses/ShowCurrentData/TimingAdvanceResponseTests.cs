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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;

using NUnit.Framework;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class TimingAdvanceResponseTests
    {
        private TimingAdvanceResponse _timingAdvanceResponse;

        [SetUp]
        public void SetUp()
        {
            _timingAdvanceResponse = new TimingAdvanceResponse();
        }

        [Test]
        public void ShouldSetTheCommand()
        {
            string message = "41 0E 45";
            string expectedCommand = "410E";
            var result = _timingAdvanceResponse.Parse(message);
            Assert.AreEqual(expectedCommand, result.Command);
        }

        [Test]
        public void ShouldSetTheData()
        {
            string message = "41 0E 45";
            string expectedData = "45";
            var result = _timingAdvanceResponse.Parse(message);
            Assert.AreEqual(expectedData, result.Data);
        }

        [Test]
        public void ShouldSetTheTimingAdvanceProperty()
        {
            string message = "41 0E 45";
            float expectedTimingAdvance = (0x45 - 128f) / 2;
            var result = _timingAdvanceResponse.Parse(message);
            Assert.AreEqual(expectedTimingAdvance, result.As<TimingAdvanceResponse>().TimingAdvance);
        }
    }
}
