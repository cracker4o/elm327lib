// Copyright 2015 Tosho Toshev
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using System.Globalization;
using System.Linq;
using ElmCommunicatorPortable.Commands;
using System;
using System.Collections;

namespace ElmCommunicatorPortable.Responses
{
    public abstract class ResponseMessage : IReceiveMessage
    {
        public string Command { get; set; }

        public string Data { get; set; }

        public string StartTermination { get; set; }

        public string EndTermination { get; set; }

        public abstract string ExpectedCommand { get; }

        public abstract IReceiveMessage Parse(string message);

        public T As<T>() where T : class
        {
            return this as T;
        }

        public int HexToDec(string hex)
        {
            if (string.IsNullOrEmpty(hex))
                throw new ArgumentNullException("hex");

            return int.Parse(hex, NumberStyles.HexNumber);
        }

        public byte ReverseByte(byte val)
        {
            byte result = 0;
            int counter = 8;
            while (counter > 0)
            {
                result <<= 1;
                result |= (byte)(val & 1);
                val = (byte)(val >> 1);
                counter--;
            }

            return result;
        }

        public byte[] StringToByteArray(string hex, bool bitSwap = false)
        {
            hex = hex.Replace(" ", string.Empty);

            return Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x =>
                {
                    byte result = Convert.ToByte(hex.Substring(x, 2), 16);
                    if (bitSwap)
                    {
                        result = ReverseByte(result);
                    }

                    return result;
                }).ToArray();
        }

        public byte ConvertBitsToByte(byte original, byte startIdx = 0, byte length = 8)
        {
            if(length < 1)
                throw new ArgumentOutOfRangeException("length");

            if (length > 8)
                throw new ArgumentOutOfRangeException("length");

            var distance = (byte)(8 - length);
            var result = original;

            if (startIdx > 0)
            {
                result = (byte)(original >> startIdx);
            }

            switch (length)
            {
                case 1:
                    result = (byte)(result & 1);
                    break;
                case 2:
                    result = (byte)(result & 3);
                    break;
                case 3:
                    result = (byte)(result & 7);
                    break;
                case 4:
                    result = (byte)(result & 15);
                    break;
                case 5:
                    result = (byte)(result & 31);
                    break;
                case 6:
                    result = (byte)(result & 63);
                    break;
                case 7:
                    result = (byte)(result & 127);
                    break;
            }

            return result;
        }

        public virtual string GetCommand(ref string message)
        {
            message = message.Replace(" ", string.Empty);
            return message.Substring(0, 4);
        }

        public virtual bool IsValid()
        {
            try
            {
                return string.Equals(this.ExpectedCommand, this.Command.Substring(2));
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
        }
    }
}