using ElmCommunicator.Commands.ObdIICommands.ShowCurrentData;
using NUnit.Framework;

namespace ElmCommunicatorTests.Commands.ObdIICommands.ShowCurrentData
{
    [TestFixture]
    public class ShortTermFuelTrimSendMessageTests
    {
        private ShortTermFuelTrimSendMessage _messageToSend;

        [Test]
        public void ShouldSendABank1Command()
        {
            const string expectedMessageData = "06";
            _messageToSend = new ShortTermFuelTrimSendMessage(FuelBanks.FirstFuelBank);
            Assert.AreEqual(expectedMessageData, _messageToSend.Data);
        }

        [Test]
        public void ShouldSendBank2Command()
        {
            const string expectedMessageData = "08";
            _messageToSend = new ShortTermFuelTrimSendMessage(FuelBanks.SecondFuelBank);
            Assert.AreEqual(expectedMessageData, _messageToSend.Data);
        }
    }
}