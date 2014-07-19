using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;
using Rhino.Mocks;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class MonitorStatusSinceDtcClearedResponseTests
    {
        private MonitorStatusSinceDtcClearedResponse _response;

        [SetUp]
        public void SetUp()
        {
            this._response = MockRepository.GeneratePartialMock<MonitorStatusSinceDtcClearedResponse>();
        }

        [Test]
        public void ShouldGetCelOrMil()
        {
            const string responseMessage = "41 01 81 00 00 00";
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.IsTrue(response.MilStatus);
        }

        [Test]
        public void ShouldGetFlaggedDtcCount()
        {
            const string responseMessage = "41 01 83 00 00 00";
            const int expectedDtcCount = 3;
            var response = (MonitorStatusSinceDtcClearedResponse) this._response.Parse(responseMessage);

            Assert.AreEqual(expectedDtcCount, response.DtcCount);
        }

        [Test]
        public void ShouldGetEngineType()
        {
            const string responseMessage = "41 01 83 00 00 00";
            const bool isSparIgnitionMotor = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(isSparIgnitionMotor, response.IsSparkIgnitionMotor);
        }

        [Test]
        public void ShouldGetMisfireProbeResult()
        {
            const string responseMessage = "41 01 83 01 00 00";
            const bool expectedMisfireResult = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedMisfireResult, response.MisfireOccured);
        }

        [Test]
        public void ShouldGetMisfireTestFailed()
        {
            const string responseMessage = "41 01 83 16 00 00";
            const bool expectedMisfireFailedResult = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedMisfireFailedResult, response.MisfireTestFailed);
        }

        [Test]
        public void ShouldGetFuelSystemProbeResult()
        {
            const string responseMessage = "41 01 83 02 00 00";
            const bool expectedFuelSystemProbeResult = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedFuelSystemProbeResult, response.FuelSystemTest);
        }

        [Test]
        public void ShouldGetFuelSystemFailedResult()
        {
            const string responseMessage = "41 01 83 20 00 00";
            const bool expectedFuelSystemFailedResult = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedFuelSystemFailedResult, response.FuelSystemTestFailed);
        }

        [Test]
        public void ShouldGetComponentsTestResult()
        {
            const string responseMessage = "41 01 83 04 00 00";
            const bool expectedComponentsTestResult = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedComponentsTestResult, response.ComponentsTest);
        }

        [Test]
        public void ShouldGetComponentsTestFailedResult()
        {
            const string responseMessage = "41 01 83 40 00 00";
            const bool expectedComponentsTestFailedResult = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedComponentsTestFailedResult, response.ComponentsTestFailed);
        }

        [Test]
        public void ShouldGetCatalystTestResult()
        {
            const string responseMessage = "41 01 83 00 01 00";
            const bool expectedCatalystResult = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedCatalystResult, response.CatalystTest);
        }

        [Test]
        public void ShouldGetCatalystFailedTestResult()
        {
            const string responseMessage = "41 01 83 00 00 01";
            const bool expectedCatalystFailedResult = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedCatalystFailedResult, response.CatalystTestFailed);
        }

        [Test]
        public void ShouldGetHeatedCatalystTestResult()
        {
            const string responseMessage = "41 01 83 00 02 00";
            const bool expectedHeatedCatalyst = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedHeatedCatalyst, response.HeatedCatalyst);
        }

        [Test]
        public void ShouldGetHeatedCatalystFailedTestResult()
        {
            const string responseMessage = "41 01 83 00 00 02";
            const bool expectedHeatedCatalystFailedTest = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedHeatedCatalystFailedTest, response.HeatedCatalystTestFailed);
        }

        [Test]
        public void ShouldGetEvaporativeSystemTestResult()
        {
            const string responseMessage = "41 01 83 00 04 00";
            const bool expectedEvaporativeSystemTest = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedEvaporativeSystemTest, response.EvaporativeSystem);
        }

        [Test]
        public void ShouldGetEvaporativeSystemTestFailedResult()
        {
            const string responseMessage = "41 01 83 00 00 04";
            const bool expectedEvaporativeSystemFailedTest = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedEvaporativeSystemFailedTest, response.EvaporativeSystemTestFailed);
        }

        [Test]
        public void ShouldGetSecondaryAirSystemTestResult()
        {
            const string responseMessage = "41 01 83 00 08 00";
            const bool expectedSecondaryAirSystemTest = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedSecondaryAirSystemTest, response.SecondaryAirSystem);
        }

        [Test]
        public void ShouldGetSecondaryAirSystemFailedTestResult()
        {
            const string responseMessage = "41 01 83 00 00 08";
            const bool expectedSecondaryAirSystemTestFailed = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedSecondaryAirSystemTestFailed, response.SecondaryAirSystemTestFailed);
        }

        [Test]
        public void ShouldGetAcRefrigerantTestResult()
        {
            const string responseMessage = "41 01 83 00 10 00";
            const bool expectedAcRefrigerantTest = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedAcRefrigerantTest, response.AcRefrigerant);
        }

        [Test]
        public void ShouldGetAcRefrigerantTestFailedResult()
        {
            const string responseMessage = "41 01 83 00 00 10";
            const bool expectedAcRefrigerantTestFailedTest = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedAcRefrigerantTestFailedTest, response.AcRefrigerantTestFailed);
        }

        [Test]
        public void ShouldGetOxygenSensorTestResult()
        {
            const string responseMessage = "41 01 83 00 20 00";
            const bool expectedOxygenSensorTestResult = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedOxygenSensorTestResult, response.OxygenSensor);
        }

        [Test]
        public void ShouldGetOxygenSensorTestFailedResult()
        {
            const string responseMessage = "41 01 83 00 00 20";
            const bool expectedOxygenSensorTestFailedResult = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedOxygenSensorTestFailedResult, response.OxygenSensorTestFailed);
        }

        [Test]
        public void ShouldGetOxygenSensorHeaterTestResult()
        {
            const string responseMessage = "41 01 83 00 40 00";
            const bool expectedOxygenSensorHeaterTestResult = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedOxygenSensorHeaterTestResult, response.OxygenSensorHeater);
        }

        [Test]
        public void ShouldGetOxygenSensorHeaterTestFailedResult()
        {
            const string responseMessage = "41 01 83 00 00 40";
            const bool expectedOxygenSensorHeaterFailedTestResult = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedOxygenSensorHeaterFailedTestResult, response.OxygenSensorHeaterTestFailed);
        }

        [Test]
        public void ShouldGetEgrSystemTestResult()
        {
            const string responseMessage = "41 01 83 00 80 00";
            const bool expectedGetEgrSystemTestResult = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedGetEgrSystemTestResult, response.EgrSystemTest);
        }

        [Test]
        public void ShouldGetEgrSystemTestFailedResult()
        {
            const string responseMessage = "41 01 83 00 00 80";
            const bool expectedGetEgrSystemTestResult = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedGetEgrSystemTestResult, response.EgrSystemTestFailed);
        }

        [Test]
        public void ShouldGetNmhcCatalystTestResult()
        {
            const string responseMessage = "41 01 83 00 01 00";
            const bool nMhcCatalystResult = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(nMhcCatalystResult, response.NmhcCatalyst);
        }

        [Test]
        public void ShouldGetNmhcCatalystTestFailedResult()
        {
            const string responseMessage = "41 01 83 00 00 01";
            const bool nMhcCatalystFailedResult = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(nMhcCatalystFailedResult, response.NmhcCatalystFailed);
        }

        [Test]
        public void ShouldGetNoxScrMonitorTestResult()
        {
            const string responseMessage = "41 01 83 00 02 00";
            const bool expectedNoxScrMonitor = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedNoxScrMonitor, response.NoxScrMonitor);
        }

        [Test]
        public void ShouldGetNoxScrMonitorTestFailedResult()
        {
            const string responseMessage = "41 01 83 00 00 02";
            const bool expectedNoxScrMonitorFailed = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedNoxScrMonitorFailed, response.NoxScrMonitorFailed);
        }

        [Test]
        public void ShouldGetBoostPressureTestResult()
        {
            const string responseMessage = "41 01 83 00 08 00";
            const bool expectedBoostPressure = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedBoostPressure, response.BoostPressure);
        }

        [Test]
        public void ShouldGetBoostPressureTestFailedResult()
        {
            const string responseMessage = "41 01 83 00 00 08";
            const bool expectedBoostPressureFailed = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedBoostPressureFailed, response.BoostPressureFailed);
        }

        [Test]
        public void ShouldGetExhaustGasSensorTestResult()
        {
            const string responseMessage = "41 01 83 00 20 00";
            const bool expectedExhaustGasSensor = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedExhaustGasSensor, response.GetExhaustGasSensor);
        }

        [Test]
        public void ShouldGetExhaustGasSensorTestFailedResult()
        {
            const string responseMessage = "41 01 83 00 00 20";
            const bool exhaustGasSensorFailed = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(exhaustGasSensorFailed, response.GetExhaustGasSensorFailed);
        }

        [Test]
        public void ShouldGetPmFilterMonitoringTestResult()
        {
            const string responseMessage = "41 01 83 00 40 00";
            const bool expectedoPmFilterMonitoring = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedoPmFilterMonitoring, response.GetPmFilterMonitoring);
        }

        [Test]
        public void ShouldGetPmFilterMonitoringTestFailedResult()
        {
            const string responseMessage = "41 01 83 00 00 40";
            const bool expectedPmFilterMonitoringTestFailed = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedPmFilterMonitoringTestFailed, response.GetPmFilterMonitoringFailed);
        }

        [Test]
        public void ShouldGetEgrAndVttSystemTestResult()
        {
            const string responseMessage = "41 01 83 00 80 00";
            const bool expectedGetEgrAndVttSystemTestResult = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedGetEgrAndVttSystemTestResult, response.GetEgrAndVttSystem);
        }

        [Test]
        public void ShouldGetEgrAndVttSystemTestFailedResult()
        {
            const string responseMessage = "41 01 83 00 00 80";
            const bool expectedGetEgrAndVttSystemTestResult = true;
            var response = (MonitorStatusSinceDtcClearedResponse)this._response.Parse(responseMessage);

            Assert.AreEqual(expectedGetEgrAndVttSystemTestResult, response.GetEgrAndVttSystemFailed);
        }
    }
}
