﻿using System;
using System.Globalization;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class AdaptiveTimingControlSendMessage : SendMessage
    {
        public AdaptiveTimingControlSendMessage(string id)
        {
            Command = "AT AT";

            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException("id", "The id parameter is empty.");
            }

            int idx;
            if (!int.TryParse(id, NumberStyles.Number, CultureInfo.InvariantCulture, out idx))
            {
                throw new ArgumentException("id");
            }

            if (!(idx >= 0 && idx <= 2))
            {
                throw new ArgumentOutOfRangeException("id", "The id is not between 0 and 2");
            }

            Data = id;
        }
    }
}