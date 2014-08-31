using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands.ObdIICommands.ShowCurrentData;
using NUnit.Framework;

namespace ElmCommunicatorTests.Commands.ObdIICommands.ShowCurrentData
{
    [TestFixture]
    public class LongTermFuelTrimSendMessageTests
    {
        private LongTermFuelTrimSendMessage _messageToSend;

        [Test]
        public void ShouldSendBank1Command()
        {
            const string expectedMessageData = "07";
            this._messageToSend = new LongTermFuelTrimSendMessage(FuelBanks.FirstFuelBank);
            Assert.AreEqual(expectedMessageData, this._messageToSend.Data);
        }
        
        [Test]
        public void ShouldSendBank2Command()
        {
            const string expectedMessageData = "09";
            this._messageToSend = new LongTermFuelTrimSendMessage(FuelBanks.SecondFuelBank);
            Assert.AreEqual(expectedMessageData, this._messageToSend.Data);
        }
    }
}
