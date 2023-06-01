using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDataSecurityEncoding
{
    internal class Base64Converter
    {
        public string StringToBase64(string inputStr)
        {
            byte[] bytes = new byte[inputStr.Length * sizeof(char)];
            Buffer.BlockCopy(inputStr.ToCharArray(), 0, bytes, 0, bytes.Length);
            string base64Output = Convert.ToBase64String(bytes);
            return base64Output;
        }
        public void Base64ToString(string nameStr)
        {            
            byte[] bytes = Convert.FromBase64String(nameStr);
            char[] chars = new char[bytes.Length / sizeof(char)];
            Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            string output = new string(chars);
            Console.WriteLine(output);

        }
    }
}
