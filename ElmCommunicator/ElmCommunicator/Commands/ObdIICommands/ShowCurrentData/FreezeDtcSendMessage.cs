﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class FreezeDtcSendMessage : SendMessage
    {
        public FreezeDtcSendMessage()
        {
            this.Command = "01";
            this.Data = "02";
        }
    }
}
