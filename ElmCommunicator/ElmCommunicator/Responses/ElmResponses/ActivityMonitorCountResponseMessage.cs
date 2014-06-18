using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;

namespace ElmCommunicator.Responses.ElmResponses
{
    public class ActivityMonitorCountResponseMessage : ResponseMessage
    {
        public ActivityMonitorCountResponseMessage()
        {
            this.Command = "AT AMC";
        }

        public override IReceiveMessage Parse(string message)
        {
            this.Data = message;

            return this;
        }
    }
}
