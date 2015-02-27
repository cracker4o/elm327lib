using ElmCommunicatorPortable.Commands;

namespace ElmCommunicatorPortable.Responses.ElmResponses
{
    public class CommonElmResponseMessage : ResponseMessage
    {
        public override IReceiveMessage Parse(string message)
        {
            this.GetCommand(ref message);
            this.Data = message.Substring(4);
            return this;
        }
    }
}
