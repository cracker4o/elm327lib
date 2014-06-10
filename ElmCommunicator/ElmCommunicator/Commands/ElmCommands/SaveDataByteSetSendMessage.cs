using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class SaveDataByteSetSendMessage : SendMessage
    {
        public SaveDataByteSetSendMessage(string data)
        {
            if(string.IsNullOrEmpty(data))
                throw new ArgumentNullException("data");

            if(this.CheckValidHexNumberByte(data))
                throw new OutOfMemoryException("data");

            this.Command = "AT SD";
            this.Data = data;
        }
    }
}
