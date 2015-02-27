using ElmCommunicatorPortable.Commands;

namespace ElmCommunicatorPortable
{
    public interface ISender
    {
        IReceiveMessage MessageResponse { get; set; }
        void Send(ISendMessage message);
    }
}