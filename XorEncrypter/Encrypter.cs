using System;
using System.Collections.Generic;
using System.Text;

namespace XorEncrypter
{
    class Encrypter
    {
        public static byte[] Encrypt(string cleartext, byte sleutel)
        {
            byte[] ciphertext = new byte[cleartext.Length];

            for (int i = 0; i < cleartext.Length; i++)
            {
                ciphertext[i] = (byte)(cleartext[i] ^ sleutel);
            }
            return ciphertext;
        }

        public static string Decrypt(byte[] ciphertext, byte sleutel)
        {
            char[] cleartext = new char[ciphertext.Length];

            for (int i = 0; i < ciphertext.Length; i++)
            {
                cleartext[i] = (char)(ciphertext[i] ^ sleutel);
            }
            return new string(cleartext);
        }
    }
}
