using ElmCommunicatorPortable.Commands;

namespace ElmCommunicatorPortable.Responses.ObdIIResponses.ShowCurrentData
{
    public class CalculatedEngineLoadValueResponse : ResponseMessage
    {
        public int EngineLoadValue { get; set; }

        public override IReceiveMessage Parse(string message)
        {
            Command = GetCommand(ref message);
            Data = message.Substring(4);
            byte[] bytes = StringToByteArray(Data);
            EngineLoadValue = bytes[0]*100/255;

            return this;
        }
    }
}