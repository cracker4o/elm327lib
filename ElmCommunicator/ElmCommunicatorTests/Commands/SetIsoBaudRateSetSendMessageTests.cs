using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands.ElmCommands;
using NUnit.Framework;

namespace ElmCommunicatorTests.Commands
{
    [TestFixture]
    public class SetIsoBaudRateSetSendMessageTests
    {
        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void ShouldSetTheProperEnumValue()
        {
            string expected = ((int) IsoBaudRateOptions.IB48).ToString(CultureInfo.InvariantCulture);
            var message = new SetIsoBaudRateSetSendMessage(IsoBaudRateOptions.IB48);

            Assert.AreEqual(expected, message.Data);
        }
    }
}
