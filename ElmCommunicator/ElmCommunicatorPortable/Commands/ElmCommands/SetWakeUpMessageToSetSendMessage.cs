using System;

namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class SetWakeUpMessageToSetSendMessage : SendMessage
    {
        public SetWakeUpMessageToSetSendMessage(byte[] message)
        {
            string hexMessage = BitConverter.ToString(message).Replace("-", string.Empty);
            Command = "AT WM";
            Data = hexMessage;
        }
    }
}