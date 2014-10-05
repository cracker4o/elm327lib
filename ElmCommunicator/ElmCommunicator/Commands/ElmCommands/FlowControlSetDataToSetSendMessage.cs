using System;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class FlowControlSetDataToSetSendMessage : SendMessage
    {
        public FlowControlSetDataToSetSendMessage(string[] dataBytes)
        {
            if (dataBytes == null)
                throw new ArgumentNullException("dataBytes");

            if (dataBytes.Length < 1 && dataBytes.Length > 5)
                throw new ArgumentOutOfRangeException("dataBytes");

            Command = "AT FC SD";
            Data = string.Join("", dataBytes);
        }
    }
}