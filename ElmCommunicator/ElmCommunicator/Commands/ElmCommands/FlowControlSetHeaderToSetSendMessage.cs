using System;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class FlowControlSetHeaderToSetSendMessage : SendMessage
    {
        public FlowControlSetHeaderToSetSendMessage(string headerValue)
        {
            if (string.IsNullOrEmpty(headerValue))
                throw new ArgumentNullException("headerValue");

            if (headerValue.Length != 3 && headerValue.Length != 8)
                throw new ArgumentOutOfRangeException("headerValue");

            Command = "AT FC SH";
            Data = headerValue;
        }
    }
}