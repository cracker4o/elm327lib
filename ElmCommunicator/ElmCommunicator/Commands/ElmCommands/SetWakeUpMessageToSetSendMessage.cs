using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class SetWakeUpMessageToSetSendMessage : SendMessage
    {
        public SetWakeUpMessageToSetSendMessage(byte[] message)
        {
            string hexMessage = BitConverter.ToString(message).Replace("-", string.Empty);
            this.Command = "AT WM";
            this.Data = hexMessage;
        }
    }
}
