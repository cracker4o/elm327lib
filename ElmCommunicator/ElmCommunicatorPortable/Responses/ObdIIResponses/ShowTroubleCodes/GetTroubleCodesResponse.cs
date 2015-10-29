using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicatorPortable.Commands;
using System.Collections;

namespace ElmCommunicatorPortable.Responses.ObdIIResponses.ShowTroubleCodes
{
    /// <summary>
    /// 
    /// </summary>
    public class GetTroubleCodesResponse : ResponseMessage
    {
        public GetTroubleCodesResponse()
        {
            dtcCodes = new List<DtcCode>();
        }

        public override string ExpectedCommand
        {
            get
            {
                return "03";
            }
        }

        public override IReceiveMessage Parse(string message)
        {
            var codes = message.Replace("\n", string.Empty).Split('\r');
            var dtcList = new List<string>();

            foreach(var rawMessage in codes)
            {
                dtcList.AddRange(this.GetDtcFromString(rawMessage));
            }

            foreach(var dtc in dtcList)
            {

            }

            return this;
        }

        public List<string> GetDtcFromString(string response)
        {
            int cnt = 0;
            var result = new List<string>();
            var dtc = string.Empty;
            var body = response.Replace(" ", string.Empty).Substring(2);

            for(int i = 0; i < body.Length; i++)
            {
                cnt++;
                dtc += body[i];
                if(cnt == 4)
                {
                    result.Add(dtc);
                    if (CodesCount > 0 && CodesCount == result.Count)
                    {
                        break;
                    }

                    cnt = 0;
                    dtc = string.Empty;
                }
            }

            return result;       
        }

        internal DtcCode ProcessDtc(string rawDtc)
        {
            var bytes = this.StringToByteArray(rawDtc);
            var codeType = (TroubleCodeType)this.ConvertBitsToByte(bytes[0], 6, 2);
            var firstDtc = ConvertBitsToByte(bytes[0], 4, 2).ToString("X1");
            var secondDtc = ConvertBitsToByte(bytes[0], 0, 4).ToString("X1");
            var thirdDtc = ConvertBitsToByte(bytes[1], 4, 4).ToString("X1");
            var fourthDtc = ConvertBitsToByte(bytes[1], 0, 4).ToString("X1");

            return new DtcCode
            {
                CodeType = codeType,
                CodeBody = firstDtc + secondDtc + thirdDtc + fourthDtc
            };
        }

        public int CodesCount { get; set; }

        public List<DtcCode> dtcCodes { get; private set; }
    }

    public enum TroubleCodeType
    {
        PowerTrain = 0,
        Chassis = 1,
        Body = 2,
        Network = 3
    }

    public class DtcCode
    {
        public TroubleCodeType CodeType { get; set; }

        public string CodeBody { get; set; }

        public override string ToString()
        {
            string result = string.Empty;

            return string.Format("{0}{1}", CodeType.ToString()[0], CodeBody);
        }
    }
}
