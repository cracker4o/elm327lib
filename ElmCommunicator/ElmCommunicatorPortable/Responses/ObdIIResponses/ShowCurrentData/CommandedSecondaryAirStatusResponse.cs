using System;
using ElmCommunicatorPortable.Commands;

namespace ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData
{
    /*
        1 Upstream
        2 Downstream of catalytic converter
        4 From the outside atmosphere or off
        8 Pump commanded on for diagnostics
     */
    public enum AirStatusOptions 
    {
        Default = 0,
        Upstream = 1,
        Downstream = 2,
        OutsideAtm = 4,
        PumpCommanded = 8
    }

    public class CommandedSecondaryAirStatusResponse : ResponseMessage
    {
        private AirStatusOptions? _airStatusOptions;

        public AirStatusOptions? AirStatusResponse 
        {
            get
            {
                return _airStatusOptions;
            }
        }

        public CommandedSecondaryAirStatusResponse()
        {
            _airStatusOptions = AirStatusOptions.Default;
        }

        public override IReceiveMessage Parse(string message)
        {
            this.Command = this.GetCommand(ref message);
            this.Data = message.Substring(4);
            byte value = byte.Parse(this.Data);

            if (Enum.IsDefined(typeof(AirStatusOptions), (AirStatusOptions)value))
            {
                _airStatusOptions = (AirStatusOptions)value;
            }
            
            return this;
        }
    }
}
