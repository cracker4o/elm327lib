using System;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class CanIdFilterSetSendMessage : SendMessage
    {
        public CanIdFilterSetSendMessage(string dataValue)
        {
            Command = "AT CF";

            if (string.IsNullOrEmpty(dataValue))
                throw new ArgumentNullException("dataValue", "The cand filter message dataValue is empty.");

            if (dataValue.Length != 2)
                throw new ArgumentOutOfRangeException("dataValue");

            Data = dataValue;
        }
    }
}