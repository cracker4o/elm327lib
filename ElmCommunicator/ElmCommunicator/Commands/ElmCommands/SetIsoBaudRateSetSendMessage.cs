using System.Globalization;

namespace ElmCommunicator.Commands.ElmCommands
{
    public enum IsoBaudRateOptions
    {
        IB10 = 10,
        IB48 = 48,
        IB96 = 96
    }

    public class SetIsoBaudRateSetSendMessage : SendMessage
    {
        public SetIsoBaudRateSetSendMessage(IsoBaudRateOptions option)
        {
            Command = "AT IB";
            Data = ((int) option).ToString(CultureInfo.InvariantCulture);
        }
    }
}