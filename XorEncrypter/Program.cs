using System;

namespace XorEncrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showCiphertext = false;
            byte sleutel = 9; // sleutel is 8 bit groot dus we kiezen byte
            var originalText = "Hallo, dit is een groot geheim!";
            var ciphertext = Encrypter.Encrypt(originalText, sleutel);
            var cleartext = Encrypter.Decrypt(ciphertext, sleutel); // cleartext zou nu gelijk moeten zijn aan "hallo"

            if (showCiphertext)
            {
                PrintBytes(ciphertext);
            }
            Console.WriteLine(originalText);
            Console.WriteLine(cleartext);
            Console.WriteLine(originalText == cleartext);
        }

        static void PrintBytes(byte[] data)
        {
            foreach (var b in data)
            {
                Console.WriteLine("0x{0,2:X} {0,5}", b);
            }
        }
    }

}

