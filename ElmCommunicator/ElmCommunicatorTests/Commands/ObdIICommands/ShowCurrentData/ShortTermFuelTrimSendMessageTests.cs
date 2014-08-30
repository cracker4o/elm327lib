using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;
using ElmCommunicator.Commands.ObdIICommands.ShowCurrentData;
using ElmCommunicatorTests.Commands.ObdIICommands.ShowCurrentData;
using NUnit.Framework;
using Rhino.Mocks;

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
            this._messageToSend = new ShortTermFuelTrimSendMessage(FuelBanks.FirstFuelBank);
            Assert.AreEqual(expectedMessageData, this._messageToSend.Data);
        }

        [Test]
        public void ShouldSendBank2Command()
        {
            const string expectedMessageData = "08";
            this._messageToSend = new ShortTermFuelTrimSendMessage(FuelBanks.SecondFuelBank);
            Assert.AreEqual(expectedMessageData, this._messageToSend.Data);
        }
    }
}
