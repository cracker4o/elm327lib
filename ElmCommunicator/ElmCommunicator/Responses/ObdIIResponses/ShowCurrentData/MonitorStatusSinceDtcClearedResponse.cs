using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    /// <summary>
    /// Message structure
    /// A = 0 1 2 3 4 5 6 7 
    /// B = 8 9 10 11 12 13 14 15 
    /// C = 16 17 18 19 20 21 22 23
    /// D = 24 25 26 27 28 29 30 31
    /// </summary>
    public class MonitorStatusSinceDtcClearedResponse : ResponseMessage
    {
        public override IReceiveMessage Parse(string message)
        {
            this.Command = this.GetCommand(ref message);
            message = message.Substring(4);
            var bytes = this.StringToByteArray(message, true);
            var bits = new BitArray(bytes);

            this.SetMilStatus(bits);
            this.SetDtcCount(bits);
            this.IsCompressionIgnitionMotor = bits[12];
            this.IsSparkIgnitionMotor = !bits[12];
            this.MisfireOccured = bits[15];
            this.MisfireTestFailed = bits[11];
            this.FuelSystemTest = bits[14];
            this.FuelSystemTestFailed = bits[10];
            this.ComponentsTest = bits[13];
            this.ComponentsTestFailed = bits[9];
            this.CatalystTest = bits[23];
            this.CatalystTestFailed = bits[31];
            this.NmhcCatalyst = bits[23];
            this.NmhcCatalystFailed = bits[31];
            this.HeatedCatalyst = bits[22];
            this.HeatedCatalystTestFailed = bits[30];
            this.NoxScrMonitor = bits[22];
            this.NoxScrMonitorFailed = bits[30];
            this.EvaporativeSystem = bits[21];
            this.EvaporativeSystemTestFailed = bits[29];
            this.SecondaryAirSystem = bits[20];
            this.SecondaryAirSystemTestFailed = bits[28];
            this.BoostPressure = bits[20];
            this.BoostPressureFailed = bits[28];
            this.AcRefrigerant = bits[19];
            this.AcRefrigerantTestFailed = bits[27];
            this.OxygenSensor = bits[18];
            this.OxygenSensorTestFailed = bits[26];
            this.GetExhaustGasSensor = bits[18];
            this.GetExhaustGasSensorFailed = bits[26];
            this.OxygenSensorHeater = bits[17];
            this.OxygenSensorHeaterTestFailed = bits[25];
            this.GetPmFilterMonitoring = bits[17];
            this.GetPmFilterMonitoringFailed = bits[25];
            this.EgrSystemTest = bits[16];
            this.EgrSystemTestFailed = bits[24];
            this.GetEgrAndVttSystem = bits[16];
            this.GetEgrAndVttSystemFailed = bits[24];

            return this;
        }

        internal virtual void SetMilStatus(BitArray bits)
        {
            this.MilStatus = bits[0];
        }

        internal virtual void SetDtcCount(BitArray bits)
        {
            this.DtcCount = this.ConvertBitArrayToByte(bits, 1, 7);
        }

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
    }
}
