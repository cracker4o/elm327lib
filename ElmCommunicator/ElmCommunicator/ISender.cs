using ElmCommunicator.Commands;

namespace ElmCommunicator
{
    public interface ISender
    {
        IReceiveMessage MessageResponse { get; set; }
        void Send(ISendMessage message);
    }
}