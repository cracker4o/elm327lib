namespace ElmCommunicatorPortable.Commands
{
    public interface IReceiveMessage : ICommunicationMessage
    {
        IReceiveMessage Parse(string message);

        T As<T>() where T : class;
    }
}