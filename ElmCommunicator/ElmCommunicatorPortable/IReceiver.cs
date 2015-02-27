using ElmCommunicatorPortable.Commands;

namespace ElmCommunicatorPortable
{
    /// <summary>
    ///     A delegate for message processing.
    /// </summary>
    /// <param name="message"></param>
    public delegate void ProcessMessage(IReceiveMessage message);

    public interface IReceiver
    {
        ProcessMessage OnProcessMessage { get; set; }
        IReceiveMessage Parse(string received, IReceiveMessage msgTemplate);

        void Process(IReceiveMessage message);
    }
}