using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class SetHeaderOoSetSendMessage : SendMessage
    {
        public SetHeaderOoSetSendMessage(string xyz)
        {
            if(string.IsNullOrEmpty(xyz))
                throw new ArgumentNullException("xyz");
            
            if(xyz.Length != 3 || xyz.Length != 6 || xyz.Length != 8 || !this.CheckValidHexNumberByte(xyz))
                throw new ArgumentOutOfRangeException("xyz");
            
            this.Command = "AT SH";
            this.Data = xyz;
        }
    }
}
