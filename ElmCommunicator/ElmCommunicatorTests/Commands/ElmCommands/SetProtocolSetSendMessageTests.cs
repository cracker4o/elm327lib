using ElmCommunicator.Commands.ElmCommands;
using NUnit.Framework;

namespace ElmCommunicatorTests.Commands.ElmCommands
{
    public class SetProtocolSetSendMessageTests
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void ShouldContainOnlyOneLetterInDataField()
        {
            var command = new SetProtocolSetSendMessage(11);
            Assert.AreEqual(1, command.Data.Length);
        }

        [Test]
        public void ShouldSetDoubleZerosForDataWhenTheResetIsTrue()
        {
            var command = new SetProtocolSetSendMessage(0, true);
            Assert.AreEqual("00", command.Data);
        }
    }
}