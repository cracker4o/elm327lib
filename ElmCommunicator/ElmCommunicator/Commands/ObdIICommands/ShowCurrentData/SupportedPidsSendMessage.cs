using System;

using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public enum SupportedPidsRange
    {
        ZeroToTwenty = 0x00,
        TwentyOneToForty = 0x20,
        FortyOneToSixty = 0x40,
        SixtyOneToEighty = 0x60,
        EightyOneToHundred = 0x80,
        HundredAndOneTo192 = 0xA0,
        HundredNinetyTwoTo224 = 0xC0
    }

    public class SupportedPidsSendMessage : SendMessage
    {
        public SupportedPidsSendMessage(SupportedPidsRange range)
        {
            this.ResponseMessage = new SupportedPidsResponse();
            Command = "01";
            Data = ((byte)range).ToString("X2");
        }
    }
}