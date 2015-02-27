using System;
using System.Globalization;

namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class KeyWordsManageSetSendMessage : SendMessage
    {
        public KeyWordsManageSetSendMessage(bool? enabled)
        {
            Command = "AT KW";

            if (enabled.HasValue)
                Data = Convert.ToInt32(enabled.Value).ToString(CultureInfo.InvariantCulture);
        }
    }
}