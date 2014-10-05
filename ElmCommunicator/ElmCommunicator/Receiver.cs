using ElmCommunicator.Commands;

namespace ElmCommunicator
{
    public class Receiver : IReceiver
    {
        public ProcessMessage OnProcessMessage { get; set; }

        public IReceiveMessage Parse(string received, IReceiveMessage msgTemplate)
        {
            return msgTemplate.Parse(received);
        }

        public void Process(IReceiveMessage message)
        {
            if (OnProcessMessage != null)
            {
                OnProcessMessage(message);
            }
        }
    }
}