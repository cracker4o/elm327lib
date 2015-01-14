using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    public class MafAirflowSensorResponseTests
    {
        private MafAirflowSensorResponse _mafAirflowSensorResponse;

        [SetUp]
        public void SetUp()
        {
            _mafAirflowSensorResponse = new MafAirflowSensorResponse();
        }

        [Test]
        public void ShouldSetTheCommand()
        {
            string expectedMessage = "41 10 30 40";
            string expectedCommand = "4110";
            var response = _mafAirflowSensorResponse.Parse(expectedMessage);
            Assert.AreEqual(expectedCommand, response.Command);
        }

        [Test]
        public void ShouldSetTheData()
        {
            string expectedMessage = "41 10 30 40";
            string expectedData = "3040";
            var response = _mafAirflowSensorResponse.Parse(expectedMessage);
            Assert.AreEqual(expectedData, response.Data);
        }

        [Test]
        public void ShouldSetMaf()
        {
            string expectedMessage = "41 10 30 40";
            double expectedMaf = (0x30 * 256.0 + 0x40) / 100; ;
            var response = _mafAirflowSensorResponse.Parse(expectedMessage);
            Assert.AreEqual(expectedMaf, ((MafAirflowSensorResponse)response).MassAirflow);
        }
    }
}
