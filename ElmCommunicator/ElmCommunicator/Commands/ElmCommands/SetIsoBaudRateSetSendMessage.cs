using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.Command = "AT IB";
            this.Data = ((int)option).ToString(CultureInfo.InvariantCulture);
        }
    }
}
