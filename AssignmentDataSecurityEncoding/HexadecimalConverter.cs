using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDataSecurityEncoding
{
    internal class HexadecimalConverter
    {
        public string  StringToHexadecimal(string inputStr)
        {          
            
            char[] values = inputStr.ToCharArray();
            string hexOutput = "";
            foreach (char letter in values)
            {
                int value = Convert.ToInt32(letter);
                hexOutput += String.Format("{0:X}", value);
            }
            
            return hexOutput;
        }
        public void HexadecimalToString(string nameStr)
        {
            var result = string.Empty;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < nameStr.Length; i += 2)
            {
                string hexChar = nameStr.Substring(i, 2);
                sb.Append((char)Convert.ToByte(hexChar, 16));
            }
            result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}









//string hexadecimalData = "";
//foreach (char c in inputStr)
//{
//    int x = (int)c;
//    string result = "";

//    while (x != 0) {
//     if (x % 16 < 10) {
//            int anthor = x % 16;
//            result = Convert.ToString(anthor) + result;     // 2+ 2 = 4   22            
//      }
//        else
//        {
//            string temp = "";
//            switch (x % 16) {
//                    case 10: temp = "A"; break;
//                    case 11: temp = "B"; break;
//                    case 12: temp = "C"; break;
//                    case 13: temp = "D"; break;
//                    case 14: temp = "E"; break;
//                    case 15: temp = "F"; break;
//            }
//            result = temp + result;
//        }
//        x /= 16;
//    }
//    hexadecimalData += result;
//    Console.WriteLine(hexadecimalData);
//}
//return hexadecimalData;
