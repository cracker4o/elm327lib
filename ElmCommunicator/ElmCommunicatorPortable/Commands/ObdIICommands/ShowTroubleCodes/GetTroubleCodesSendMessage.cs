using ElmCommunicatorPortable.Responses.ObdIIResponses.ShowTroubleCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicatorPortable.Commands.ObdIICommands.ShowTroubleCodes
{
    public class GetTroubleCodesSendMessage : SendMessage
    {
        public GetTroubleCodesSendMessage()
        {
            this.Command = "03";
            this.ResponseMessage = new GetTroubleCodesResponse();
        }

        public GetTroubleCodesSendMessage(int codesCount) :this()
        {
            (this.ResponseMessage as GetTroubleCodesResponse).CodesCount = codesCount;
        }
    }
}
