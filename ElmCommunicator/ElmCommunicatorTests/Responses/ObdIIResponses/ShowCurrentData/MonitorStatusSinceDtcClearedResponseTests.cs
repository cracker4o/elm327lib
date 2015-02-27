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
using Rhino.Mocks;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class MonitorStatusSinceDtcClearedResponseTests
    {
        [SetUp]
        public void SetUp()
        {
            _response = MockRepository.GeneratePartialMock<MonitorStatusSinceDtcClearedResponse>();
        }

        private MonitorStatusSinceDtcClearedResponse _response;

        [Test]
        public void ShouldGetAcRefrigerantTestFailedResult()
        {
            const string responseMessage = "41 01 83 00 00 10";
            const bool expectedAcRefrigerantTestFailedTest = true;
            var response = (MonitorStatusSinceDtcClearedResponse) _response.Parse(responseMessage);

            Assert.AreEqual(expectedAcRefrigerantTestFailedTest, response.AcRefrigerantTestFailed);
        }

        [Test]
        public void ShouldGetAcRefrigerantTestResult()
        {
            const string responseMessage = "41 01 83 00 10 00";
            const bool expectedAcRefrigerantTest = true;
            var response = (MonitorStatusSinceDtcClearedResponse) _response.Parse(responseMessage);

            Assert.AreEqual(expectedAcRefrigerantTest, response.AcRefrigerant);
        }

        [Test]
        public void ShouldGetBoostPressureTestFailedResult()
        {
            const string responseMessage = "41 01 83 00 00 08";
            const bool expectedBoostPressureFailed = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedBoostPressureFailed, response.As<MonitorStatusSinceDtcClearedResponse>().BoostPressureFailed);
        }

        [Test]
        public void ShouldGetBoostPressureTestResult()
        {
            const string responseMessage = "41 01 83 00 08 00";
            const bool expectedBoostPressure = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedBoostPressure, response.As<MonitorStatusSinceDtcClearedResponse>().BoostPressure);
        }

        [Test]
        public void ShouldGetCatalystFailedTestResult()
        {
            const string responseMessage = "41 01 83 00 00 01";
            const bool expectedCatalystFailedResult = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedCatalystFailedResult, response.As<MonitorStatusSinceDtcClearedResponse>().CatalystTestFailed);
        }

        [Test]
        public void ShouldGetCatalystTestResult()
        {
            const string responseMessage = "41 01 83 00 01 00";
            const bool expectedCatalystResult = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedCatalystResult, response.As<MonitorStatusSinceDtcClearedResponse>().CatalystTest);
        }

        [Test]
        public void ShouldGetCelOrMil()
        {
            const string responseMessage = "41 01 81 00 00 00";
            var response = _response.Parse(responseMessage);

            Assert.IsTrue(response.As<MonitorStatusSinceDtcClearedResponse>().MilStatus);
        }

        [Test]
        public void ShouldGetComponentsTestFailedResult()
        {
            const string responseMessage = "41 01 83 40 00 00";
            const bool expectedComponentsTestFailedResult = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedComponentsTestFailedResult, response.As<MonitorStatusSinceDtcClearedResponse>().ComponentsTestFailed);
        }

        [Test]
        public void ShouldGetComponentsTestResult()
        {
            const string responseMessage = "41 01 83 04 00 00";
            const bool expectedComponentsTestResult = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedComponentsTestResult, response.As<MonitorStatusSinceDtcClearedResponse>().ComponentsTest);
        }

        [Test]
        public void ShouldGetEgrAndVttSystemTestFailedResult()
        {
            const string responseMessage = "41 01 83 00 00 80";
            const bool expectedGetEgrAndVttSystemTestResult = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedGetEgrAndVttSystemTestResult, response.As<MonitorStatusSinceDtcClearedResponse>().GetEgrAndVttSystemFailed);
        }

        [Test]
        public void ShouldGetEgrAndVttSystemTestResult()
        {
            const string responseMessage = "41 01 83 00 80 00";
            const bool expectedGetEgrAndVttSystemTestResult = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedGetEgrAndVttSystemTestResult, response.As<MonitorStatusSinceDtcClearedResponse>().GetEgrAndVttSystem);
        }

        [Test]
        public void ShouldGetEgrSystemTestFailedResult()
        {
            const string responseMessage = "41 01 83 00 00 80";
            const bool expectedGetEgrSystemTestResult = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedGetEgrSystemTestResult, response.As<MonitorStatusSinceDtcClearedResponse>().EgrSystemTestFailed);
        }

        [Test]
        public void ShouldGetEgrSystemTestResult()
        {
            const string responseMessage = "41 01 83 00 80 00";
            const bool expectedGetEgrSystemTestResult = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedGetEgrSystemTestResult, response.As<MonitorStatusSinceDtcClearedResponse>().EgrSystemTest);
        }

        [Test]
        public void ShouldGetEngineType()
        {
            const string responseMessage = "41 01 83 00 00 00";
            const bool isSparIgnitionMotor = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(isSparIgnitionMotor, response.As<MonitorStatusSinceDtcClearedResponse>().IsSparkIgnitionMotor);
        }

        [Test]
        public void ShouldGetEvaporativeSystemTestFailedResult()
        {
            const string responseMessage = "41 01 83 00 00 04";
            const bool expectedEvaporativeSystemFailedTest = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedEvaporativeSystemFailedTest, response.As<MonitorStatusSinceDtcClearedResponse>().EvaporativeSystemTestFailed);
        }

        [Test]
        public void ShouldGetEvaporativeSystemTestResult()
        {
            const string responseMessage = "41 01 83 00 04 00";
            const bool expectedEvaporativeSystemTest = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedEvaporativeSystemTest, response.As<MonitorStatusSinceDtcClearedResponse>().EvaporativeSystem);
        }

        [Test]
        public void ShouldGetExhaustGasSensorTestFailedResult()
        {
            const string responseMessage = "41 01 83 00 00 20";
            const bool exhaustGasSensorFailed = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(exhaustGasSensorFailed, response.As<MonitorStatusSinceDtcClearedResponse>().GetExhaustGasSensorFailed);
        }

        [Test]
        public void ShouldGetExhaustGasSensorTestResult()
        {
            const string responseMessage = "41 01 83 00 20 00";
            const bool expectedExhaustGasSensor = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedExhaustGasSensor, response.As<MonitorStatusSinceDtcClearedResponse>().GetExhaustGasSensor);
        }

        [Test]
        public void ShouldGetFlaggedDtcCount()
        {
            const string responseMessage = "41 01 83 00 00 00";
            const int expectedDtcCount = 3;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedDtcCount, response.As<MonitorStatusSinceDtcClearedResponse>().DtcCount);
        }

        [Test]
        public void ShouldGetFuelSystemFailedResult()
        {
            const string responseMessage = "41 01 83 20 00 00";
            const bool expectedFuelSystemFailedResult = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedFuelSystemFailedResult, response.As<MonitorStatusSinceDtcClearedResponse>().FuelSystemTestFailed);
        }

        [Test]
        public void ShouldGetFuelSystemProbeResult()
        {
            const string responseMessage = "41 01 83 02 00 00";
            const bool expectedFuelSystemProbeResult = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedFuelSystemProbeResult, response.As<MonitorStatusSinceDtcClearedResponse>().FuelSystemTest);
        }

        [Test]
        public void ShouldGetHeatedCatalystFailedTestResult()
        {
            const string responseMessage = "41 01 83 00 00 02";
            const bool expectedHeatedCatalystFailedTest = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedHeatedCatalystFailedTest, response.As<MonitorStatusSinceDtcClearedResponse>().HeatedCatalystTestFailed);
        }

        [Test]
        public void ShouldGetHeatedCatalystTestResult()
        {
            const string responseMessage = "41 01 83 00 02 00";
            const bool expectedHeatedCatalyst = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedHeatedCatalyst, response.As<MonitorStatusSinceDtcClearedResponse>().HeatedCatalyst);
        }

        [Test]
        public void ShouldGetMisfireProbeResult()
        {
            const string responseMessage = "41 01 83 01 00 00";
            const bool expectedMisfireResult = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedMisfireResult, response.As<MonitorStatusSinceDtcClearedResponse>().MisfireOccured);
        }

        [Test]
        public void ShouldGetMisfireTestFailed()
        {
            const string responseMessage = "41 01 83 16 00 00";
            const bool expectedMisfireFailedResult = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedMisfireFailedResult, response.As<MonitorStatusSinceDtcClearedResponse>().MisfireTestFailed);
        }

        [Test]
        public void ShouldGetNmhcCatalystTestFailedResult()
        {
            const string responseMessage = "41 01 83 00 00 01";
            const bool nMhcCatalystFailedResult = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(nMhcCatalystFailedResult, response.As<MonitorStatusSinceDtcClearedResponse>().NmhcCatalystFailed);
        }

        [Test]
        public void ShouldGetNmhcCatalystTestResult()
        {
            const string responseMessage = "41 01 83 00 01 00";
            const bool nMhcCatalystResult = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(nMhcCatalystResult, response.As<MonitorStatusSinceDtcClearedResponse>().NmhcCatalyst);
        }

        [Test]
        public void ShouldGetNoxScrMonitorTestFailedResult()
        {
            const string responseMessage = "41 01 83 00 00 02";
            const bool expectedNoxScrMonitorFailed = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedNoxScrMonitorFailed, response.As<MonitorStatusSinceDtcClearedResponse>().NoxScrMonitorFailed);
        }

        [Test]
        public void ShouldGetNoxScrMonitorTestResult()
        {
            const string responseMessage = "41 01 83 00 02 00";
            const bool expectedNoxScrMonitor = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedNoxScrMonitor, response.As<MonitorStatusSinceDtcClearedResponse>().NoxScrMonitor);
        }

        [Test]
        public void ShouldGetOxygenSensorHeaterTestFailedResult()
        {
            const string responseMessage = "41 01 83 00 00 40";
            const bool expectedOxygenSensorHeaterFailedTestResult = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedOxygenSensorHeaterFailedTestResult, response.As<MonitorStatusSinceDtcClearedResponse>().OxygenSensorHeaterTestFailed);
        }

        [Test]
        public void ShouldGetOxygenSensorHeaterTestResult()
        {
            const string responseMessage = "41 01 83 00 40 00";
            const bool expectedOxygenSensorHeaterTestResult = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedOxygenSensorHeaterTestResult, response.As<MonitorStatusSinceDtcClearedResponse>().OxygenSensorHeater);
        }

        [Test]
        public void ShouldGetOxygenSensorTestFailedResult()
        {
            const string responseMessage = "41 01 83 00 00 20";
            const bool expectedOxygenSensorTestFailedResult = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedOxygenSensorTestFailedResult, response.As<MonitorStatusSinceDtcClearedResponse>().OxygenSensorTestFailed);
        }

        [Test]
        public void ShouldGetOxygenSensorTestResult()
        {
            const string responseMessage = "41 01 83 00 20 00";
            const bool expectedOxygenSensorTestResult = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedOxygenSensorTestResult, response.As<MonitorStatusSinceDtcClearedResponse>().OxygenSensor);
        }

        [Test]
        public void ShouldGetPmFilterMonitoringTestFailedResult()
        {
            const string responseMessage = "41 01 83 00 00 40";
            const bool expectedPmFilterMonitoringTestFailed = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedPmFilterMonitoringTestFailed, response.As<MonitorStatusSinceDtcClearedResponse>().GetPmFilterMonitoringFailed);
        }

        [Test]
        public void ShouldGetPmFilterMonitoringTestResult()
        {
            const string responseMessage = "41 01 83 00 40 00";
            const bool expectedoPmFilterMonitoring = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedoPmFilterMonitoring, response.As<MonitorStatusSinceDtcClearedResponse>().GetPmFilterMonitoring);
        }

        [Test]
        public void ShouldGetSecondaryAirSystemFailedTestResult()
        {
            const string responseMessage = "41 01 83 00 00 08";
            const bool expectedSecondaryAirSystemTestFailed = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedSecondaryAirSystemTestFailed, response.As<MonitorStatusSinceDtcClearedResponse>().SecondaryAirSystemTestFailed);
        }

        [Test]
        public void ShouldGetSecondaryAirSystemTestResult()
        {
            const string responseMessage = "41 01 83 00 08 00";
            const bool expectedSecondaryAirSystemTest = true;
            var response = _response.Parse(responseMessage);

            Assert.AreEqual(expectedSecondaryAirSystemTest, response.As<MonitorStatusSinceDtcClearedResponse>().SecondaryAirSystem);
        }
    }
}