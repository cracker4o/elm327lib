using System;
using ElmCommunicator.Responses.ElmResponses;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class ActivityMonitorTimeoutSendMessage : SendMessage
    {
        public ActivityMonitorTimeoutSendMessage()
        {
            Command = "AT AMT";
        }

        public ActivityMonitorTimeoutSendMessage(string data)
        {
            this.ResponseMessage = new ActivityMonitorTimeoutResponseMessage();
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException("data", "The data is empty");
            }

            if (!CheckValidHexNumberByte(data))
            {
                throw new ArgumentOutOfRangeException("data", "The data is not a valid HEX number.");
            }

            Data = data;
        }
    }
}