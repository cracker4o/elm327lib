using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ElmCommands
{
    public class AdaptiveTimingControlMessage : Message
    {
        public AdaptiveTimingControlMessage(string id)
        {
            this.Command = "AT AT";

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

            this.Data = id;
        }
    }
}
