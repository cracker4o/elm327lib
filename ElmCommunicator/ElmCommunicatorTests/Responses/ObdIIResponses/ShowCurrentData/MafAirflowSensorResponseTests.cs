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

using ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData;
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
            double expectedMaf = ((0x30 * 256.0) + 0x40) / 100;
            var response = _mafAirflowSensorResponse.Parse(expectedMessage);
            Assert.AreEqual(expectedMaf, response.As<MafAirflowSensorResponse>().MassAirflow);
        }

        [Test]
        public void ShouldReturnNullWhenWrongCommand()
        {
            string expectedMessage = "41 05 30 40";
            var response = _mafAirflowSensorResponse.Parse(expectedMessage);
            Assert.IsNull(response);
        }
    }
}
