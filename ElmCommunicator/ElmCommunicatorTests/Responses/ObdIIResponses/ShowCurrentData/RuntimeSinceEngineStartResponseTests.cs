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
