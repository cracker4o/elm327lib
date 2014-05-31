using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class FlowControlSetDataToSetSendMessage : SendMessage
    {
        public FlowControlSetDataToSetSendMessage(string[] dataBytes)
        {
            if(dataBytes == null)
                throw new ArgumentNullException("dataBytes");

            if(dataBytes.Length < 1 && dataBytes.Length > 5)
                throw new ArgumentOutOfRangeException("dataBytes");

            this.Command = "AT FC SD";
            this.Data = string.Join("", dataBytes);

        }
    }
}
