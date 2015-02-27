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
    public class RuntimeSinceEngineStartResponseTests
    {
        private RuntimeSinceEngineStartResponse _response;

        [SetUp]
        public void SetUp()
        {
            _response = new RuntimeSinceEngineStartResponse();
        }

        [Test]
        public void ShouldSetTheCommand()
        {
            string message = "41 1F 05 05";
            var response = this._response.Parse(message);
            Assert.AreEqual("411F", response.Command);
        }

        [Test]
        public void ShouldSetTheData()
        {
            string message = "41 1F 05 05";
            var response = this._response.Parse(message);
            Assert.AreEqual("0505", response.Data);
        }

        [Test]
        public void ShouldSetTheRunningTime()
        {
            string message = "41 1F 0A 0A";
            var response = this._response.Parse(message);
            Assert.AreEqual(2570, response.As<RuntimeSinceEngineStartResponse>().EngineTime);
        }
    }
}
