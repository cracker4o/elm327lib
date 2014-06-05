using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class KeyWordsManageSetSendMessage : SendMessage
    {
        public KeyWordsManageSetSendMessage(bool? enabled)
        {
            this.Command = "AT KW";

            if (enabled.HasValue)
                this.Data = Convert.ToInt32(enabled.Value).ToString(CultureInfo.InvariantCulture);
        }
    }
}
