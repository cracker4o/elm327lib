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
using System.Collections;
using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    /// <summary>
    ///     Message structure
    ///     A = 0 1 2 3 4 5 6 7
    ///     B = 8 9 10 11 12 13 14 15
    ///     C = 16 17 18 19 20 21 22 23
    ///     D = 24 25 26 27 28 29 30 31
    /// </summary>
    public class MonitorStatusSinceDtcClearedResponse : ResponseMessage
    {
        public bool IsCompressionIgnitionMotor { get; private set; }

        public bool IsSparkIgnitionMotor { get; private set; }

        public bool MilStatus { get; private set; }

        public int DtcCount { get; private set; }

        public bool MisfireOccured { get; private set; }

        public bool MisfireTestFailed { get; private set; }

        public bool FuelSystemTest { get; private set; }

        public bool FuelSystemTestFailed { get; private set; }

        public bool ComponentsTest { get; private set; }

        public bool ComponentsTestFailed { get; private set; }

        public bool CatalystTest { get; private set; }

        public bool CatalystTestFailed { get; private set; }

        public bool HeatedCatalyst { get; private set; }

        public bool HeatedCatalystTestFailed { get; private set; }

        public bool EvaporativeSystem { get; private set; }

        public bool EvaporativeSystemTestFailed { get; private set; }

        public bool SecondaryAirSystem { get; private set; }

        public bool SecondaryAirSystemTestFailed { get; private set; }

        public bool AcRefrigerant { get; private set; }

        public bool AcRefrigerantTestFailed { get; private set; }

        public bool OxygenSensor { get; private set; }

        public bool OxygenSensorTestFailed { get; private set; }

        public bool OxygenSensorHeater { get; private set; }

        public bool OxygenSensorHeaterTestFailed { get; private set; }

        public bool EgrSystemTest { get; private set; }

        public bool EgrSystemTestFailed { get; private set; }

        public bool NmhcCatalyst { get; private set; }

        public bool NmhcCatalystFailed { get; private set; }

        public bool NoxScrMonitor { get; private set; }

        public bool NoxScrMonitorFailed { get; private set; }

        public bool BoostPressure { get; private set; }

        public bool BoostPressureFailed { get; private set; }

        public bool GetExhaustGasSensor { get; private set; }

        public bool GetExhaustGasSensorFailed { get; private set; }

        public bool GetPmFilterMonitoring { get; private set; }

        public bool GetPmFilterMonitoringFailed { get; private set; }

        public bool GetEgrAndVttSystem { get; private set; }

        public bool GetEgrAndVttSystemFailed { get; private set; }

        public override IReceiveMessage Parse(string message)
        {
            Command = GetCommand(ref message);
            message = message.Substring(4);
            byte[] bytes = StringToByteArray(message, true);
            var bits = new BitArray(bytes);

            SetMilStatus(bits);
            SetDtcCount(bits);
            IsCompressionIgnitionMotor = bits[12];
            IsSparkIgnitionMotor = !bits[12];
            MisfireOccured = bits[15];
            MisfireTestFailed = bits[11];
            FuelSystemTest = bits[14];
            FuelSystemTestFailed = bits[10];
            ComponentsTest = bits[13];
            ComponentsTestFailed = bits[9];
            CatalystTest = bits[23];
            CatalystTestFailed = bits[31];
            NmhcCatalyst = bits[23];
            NmhcCatalystFailed = bits[31];
            HeatedCatalyst = bits[22];
            HeatedCatalystTestFailed = bits[30];
            NoxScrMonitor = bits[22];
            NoxScrMonitorFailed = bits[30];
            EvaporativeSystem = bits[21];
            EvaporativeSystemTestFailed = bits[29];
            SecondaryAirSystem = bits[20];
            SecondaryAirSystemTestFailed = bits[28];
            BoostPressure = bits[20];
            BoostPressureFailed = bits[28];
            AcRefrigerant = bits[19];
            AcRefrigerantTestFailed = bits[27];
            OxygenSensor = bits[18];
            OxygenSensorTestFailed = bits[26];
            GetExhaustGasSensor = bits[18];
            GetExhaustGasSensorFailed = bits[26];
            OxygenSensorHeater = bits[17];
            OxygenSensorHeaterTestFailed = bits[25];
            GetPmFilterMonitoring = bits[17];
            GetPmFilterMonitoringFailed = bits[25];
            EgrSystemTest = bits[16];
            EgrSystemTestFailed = bits[24];
            GetEgrAndVttSystem = bits[16];
            GetEgrAndVttSystemFailed = bits[24];

            return this;
        }

        internal virtual void SetMilStatus(BitArray bits)
        {
            MilStatus = bits[0];
        }

        internal virtual void SetDtcCount(BitArray bits)
        {
            DtcCount = ConvertBitArrayToByte(bits, 1, 7);
        }
    }
}