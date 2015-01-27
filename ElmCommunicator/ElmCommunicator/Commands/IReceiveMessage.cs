using UnitsNet;

namespace ElmCommunicator.Commands
{
    public interface IReceiveMessage : ICommunicationMessage
    {
        IReceiveMessage Parse(string message);
    }
}