namespace ElmCommunicatorPortable.Commands
{
    public interface ISendMessage : ICommunicationMessage
    {
        IReceiveMessage ResponseMessage { get; set; }
    }
}