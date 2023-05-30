using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDataSecurityEncoding
{
    internal class BinaryConverter
    {
        public string StringToBinary(string inputStr)
        {
            string binaryVersion = "";
            foreach (var c in inputStr)
            {
                string binary = "";
                int asciiValue = (int)c;
                while (asciiValue > 1)
                {
                    int remainder = asciiValue % 2; // the remainder of 65 is 1 || 32 doesnot have a remainder
                    binary = Convert.ToString(remainder) + binary; // covert the 1 to string 1+1 =2 1+1 =11 ||0+1 = 01 || 0+01 = 001
                    asciiValue /= 2; // 65/2 =32 is 32 greater than 1
                }
                binary = Convert.ToString(asciiValue) + binary; // 1 + 000001 = 1000001
                binaryVersion = binaryVersion + binary.PadLeft(8, '0');
                Console.WriteLine($"8 bit ASCII for {c} = {(int)c} and binary = {binary.PadLeft(8, '0')}"); // 0 + 1000001
                Console.WriteLine($"7 bit ASCII for {c} = {(int)c} and binary = {binary.PadLeft(7, '0')}");
            }
            Console.WriteLine($"Length of Binary string {binaryVersion.Length}");

            return binaryVersion;
        }
        public void BinaryToString(string inputStr) {
            string result = "";
            for(int i = 0; i < inputStr.Length; i += 8) {
            string first8Bits = inputStr.Substring(i, 8);
            int number = Convert.ToInt32(first8Bits);
                result += (char)number;
            }
        }

    }
}
