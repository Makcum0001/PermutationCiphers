using System.Runtime.CompilerServices;

namespace Ciphers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = "ТЕРМИНАТОР ПРИ";
            int encryptKey = 3;
            string encryptStr = str.Encrypt(encryptKey);
            string decryptStr = encryptStr.Decrypt();
            Console.WriteLine($"Original string: {str}\n\nEncrypt string: {encryptStr}\n\nDecrypt string: {decryptStr}\n{str.Length==decryptStr.Length}");
            Console.ReadKey();
           
        }

    }

    
}		
