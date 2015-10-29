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

using ElmCommunicatorPortable.Commands;
using System.Collections;

namespace ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData
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

        public override string ExpectedCommand
        {
            get
            {
                return "01";
            }
        }

        public override IReceiveMessage Parse(string message)
        {
            Command = GetCommand(ref message);
            if (!this.IsValid())
            {
                return null;
            }

            message = message.Substring(4);
            byte[] bytes = StringToByteArray(message);
            var bits = new BitArray(bytes);

            SetMilStatus(bits);
            SetDtcCount(bytes[0]);

            IsCompressionIgnitionMotor = bits[12];
            IsSparkIgnitionMotor = !bits[12];
            MisfireOccured = bits[8];
            MisfireTestFailed = bits[9];
            FuelSystemTest = bits[9];
            FuelSystemTestFailed = bits[13];
            ComponentsTest = bits[10];
            ComponentsTestFailed = bits[14];
            CatalystTest = bits[16];
            CatalystTestFailed = bits[24];
            NmhcCatalyst = bits[16];
            NmhcCatalystFailed = bits[24];
            HeatedCatalyst = bits[17];
            HeatedCatalystTestFailed = bits[25];
            NoxScrMonitor = bits[17];
            NoxScrMonitorFailed = bits[25];
            EvaporativeSystem = bits[18];
            EvaporativeSystemTestFailed = bits[26];
            SecondaryAirSystem = bits[19];
            SecondaryAirSystemTestFailed = bits[27];
            BoostPressure = bits[19];
            BoostPressureFailed = bits[27];
            AcRefrigerant = bits[20];
            AcRefrigerantTestFailed = bits[28];
            OxygenSensor = bits[21];
            OxygenSensorTestFailed = bits[29];
            GetExhaustGasSensor = bits[21];
            GetExhaustGasSensorFailed = bits[29];
            OxygenSensorHeater = bits[22];
            OxygenSensorHeaterTestFailed = bits[30];
            GetPmFilterMonitoring = bits[22];
            GetPmFilterMonitoringFailed = bits[30];
            EgrSystemTest = bits[23];
            EgrSystemTestFailed = bits[31];
            GetEgrAndVttSystem = bits[23];
            GetEgrAndVttSystemFailed = bits[31];

            return this;
        }

        internal virtual void SetMilStatus(BitArray bits)
        {
            MilStatus = bits[7];
        }

        internal virtual void SetDtcCount(byte input)
        {
            DtcCount = ConvertBitsToByte(input, 0, 7);
        }
    }
}