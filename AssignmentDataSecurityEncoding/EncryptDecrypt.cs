﻿using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDataSecurityEncoding
{
    internal class EncryptDecrypt
    {
        public (string, byte[], byte[]) EncryptString(string plainText)
        {
            byte[] encrypted, key, iv;

            using (Aes aes = Aes.Create())
            {
                //byte[] key and byte[] iv are byte arrays that represent the key and initialization vector(IV) for the encryption algorithm.
                // byte[] key and byte[] are generated by aes everytime the run the code
                key = aes.Key;
                iv = aes.IV;
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }
                        encrypted = ms.ToArray();
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach (byte b in encrypted)
            {
                sb.Append((char)(b + 33));
            }
            return (sb.ToString(), key, iv );
        }

        public void DecryptString(string cipherText, byte[] key, byte[] iv)
        {
            byte[] encrypted = new byte[cipherText.Length];
            for (int i = 0; i < cipherText.Length; i++)
            {
                encrypted[i] = (byte)(cipherText[i] - 33);
            }

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream(encrypted))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            Console.WriteLine(sr.ReadToEnd()); 
                        }
                    }
                }
            }
        }
    }
}
