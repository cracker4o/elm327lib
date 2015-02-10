using ElmCommunicator.Commands.ObdIICommands.ShowCurrentData;
using NUnit.Framework;

namespace ElmCommunicatorTests.Commands.ObdIICommands.ShowCurrentData
{
    [TestFixture]
    public class SupportedPidsSendMessageTests
    {
        private SupportedPidsSendMessage _command;

        [Test]
        public void ShouldGenerateZeroToTwentyRangeCommand()
        {
            this._command = new SupportedPidsSendMessage(SupportedPidsRange.ZeroToTwenty);
            Assert.AreEqual("0100\r\n", this._command.ToString());
        }

        [Test]
        public void ShouldGenerateTwentyOneToFortyRangeCommand()
        {
            this._command = new SupportedPidsSendMessage(SupportedPidsRange.TwentyOneToForty);
            Assert.AreEqual("0120\r\n", this._command.ToString());
        }

        [Test]
        public void ShouldGenerateFortyOneToSixtyRangeCommand()
        {
            this._command = new SupportedPidsSendMessage(SupportedPidsRange.FortyOneToSixty);
            Assert.AreEqual("0140\r\n", this._command.ToString());
        }

        [Test]
        public void ShouldGenerateSixtyOneToEightyRangeCommand()
        {
            this._command = new SupportedPidsSendMessage(SupportedPidsRange.SixtyOneToEighty);
            Assert.AreEqual("0160\r\n", this._command.ToString());
        }

        [Test]
        public void ShouldGenerateEightyOneToHundredRangeCommand()
        {
            this._command = new SupportedPidsSendMessage(SupportedPidsRange.EightyOneToHundred);
            Assert.AreEqual("0180\r\n", this._command.ToString());
        }

        [Test]
        public void ShouldGenerateHundredAndOneTo192RangeCommand()
        {
            this._command = new SupportedPidsSendMessage(SupportedPidsRange.HundredAndOneTo192);
            Assert.AreEqual("01A0\r\n", this._command.ToString());
        }

        [Test]
        public void ShouldGenerateHundredNinetyTwoTo224RangeCommand()
        {
            this._command = new SupportedPidsSendMessage(SupportedPidsRange.HundredNinetyTwoTo224);
            Assert.AreEqual("01C0\r\n", this._command.ToString());
        }
    }
}
