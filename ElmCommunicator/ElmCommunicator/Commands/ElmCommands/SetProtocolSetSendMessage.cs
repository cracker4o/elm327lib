using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class SetProtocolSetSendMessage : SendMessage
    {
        public SetProtocolSetSendMessage(byte protocolId, bool reset = false)
        {
            if(protocolId > 12)
                throw new ArgumentOutOfRangeException("protocolId");

            this.Command = "AT SP";
            if (reset)
            {
                this.Data = "00";
            }
            else
            {
                this.Data = protocolId.ToString("X")
                                     .Last()
                                     .ToString(CultureInfo.InvariantCulture);   
            }
        }
    }
}
