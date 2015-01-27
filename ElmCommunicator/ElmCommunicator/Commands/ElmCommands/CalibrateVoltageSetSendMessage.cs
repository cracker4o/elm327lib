using System;
using ElmCommunicator.Responses.ElmResponses;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class CalibrateVoltageSetSendMessage : SendMessage
    {
        /// <summary>
        ///     Calibrates the voltage. If you set voltage to 0000 it restores the default value.
        /// </summary>
        /// <param name="voltage"></param>
        public CalibrateVoltageSetSendMessage(string voltage)
        {
            this.ResponseMessage = new CommonElmResponseMessage();
            if (string.IsNullOrEmpty(voltage))
                throw new ArgumentNullException("voltage", "Please provide voltage for this command.");

            if (voltage.Length != 4)
                throw new ArgumentOutOfRangeException("voltage");

            Command = "AT CV";
            Data = voltage;
        }
    }
}