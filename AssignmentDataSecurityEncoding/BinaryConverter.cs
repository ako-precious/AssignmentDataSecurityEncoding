using Microsoft.VisualBasic;
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
            string result = "";
            foreach (char ch in inputStr)
            {
                //Convert each character in to strings after being converted into binary
                string eightbit = Convert.ToString((int)ch, 2);

                //making each character an eight bit character
                result += eightbit.PadLeft(8, '0');

            }
            binaryVersion = result;
            return binaryVersion;  

        }
        public void BinaryToString(string nameStr)
        {
            var result = string.Empty;
            byte[] bytes = new byte[nameStr.Length / 8];
            for (int i = 0; i < bytes.Length; i++)
            {
                // coverting each substring to a byte
                bytes[i] = Convert.ToByte(nameStr.Substring(i * 8, 8), 2);
            }
            // coverting it back to a string
            var sb = new StringBuilder();
            foreach (var b in bytes)
            {
                sb.Append((char)b);
            }
            result = sb.ToString();
            Console.WriteLine(result);            
        }
    }
}




















//binaryVersion = binaryVersion + result.PadLeft(8, '0');
//foreach (var c in nameStr)
//{
//    string binary = "";
//    int asciiValue = (int)c;
//    while (asciiValue > 1)
//    {
//        int remainder = asciiValue % 2; // the remainder of 65 is 1 || 32 doesnot have a remainder
//        binary = Convert.ToString(remainder) + binary; // covert the 1 to string 1+1 =2 1+1 =11 ||0+1 = 01 || 0+01 = 001
//        asciiValue /= 2; // 65/2 =32 is 32 greater than 1
//    }
//    binary = Convert.ToString(asciiValue) + binary; // 1 + 000001 = 1000001
//    binaryVersion = binaryVersion + binary.PadLeft(8, '0');
//    Console.WriteLine($"8 bit ASCII for {c} = {(int)c} and binary = {binary.PadLeft(8, '0')}"); // 0 + 1000001
//    Console.WriteLine($"7 bit ASCII for {c} = {(int)c} and binary = {binary.PadLeft(7, '0')}");
//}
//Console.WriteLine($"Length of Binary string {binaryVersion.Length}");

//for (int i = 0; i < nameStr.Length; i += 8)
//{
//    string first8Bits = nameStr.Substring(i, 8);
//    string binaryToString = Convert.ToString(first8Bits, 2);
//    result = binaryToString;
//   
//    //string base64Data = Convert.ToBase64String(first8Bits);


//    //int number = Convert.ToInt32(first8Bits);
//    //result += (char)number;
//}