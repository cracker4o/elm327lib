using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class InFrameResponseControlSetSendMessage : SendMessage
    {
        public InFrameResponseControlSetSendMessage(string mode)
        {
            int modeId;
            if (int.TryParse(mode, out modeId))
            {
                if(modeId < 0 || modeId > 2)
                    throw new ArgumentOutOfRangeException("mode");
            }
            else
            {
                if(!string.Equals(mode, "S") && !string.Equals(mode, "H"))
                    throw new ArgumentOutOfRangeException("mode", "The IFR mode is not valid.");

            }

            this.Command = "AT IFR";
            this.Data = mode;
        }
    }
}
