using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciphers
{
    public static class PermutationCipher
    {
        private static string _str = "";
        private static int _key = 0;
        public static string Encrypt(this string str, int key)
        {
            if (key < 0 || str.Length == 0) throw new ArgumentException();

            str = str.Trim().ToUpper();
            string encryptStr = "";
            int columns = (int)Math.Ceiling((double)str.Length / key);
            _key = key;

            for (int i = 0; i < key; i++)
            {
                int spaceCounter = 0;
                for (int j = i; j < str.Length; j += key)
                {
                    encryptStr += str[j];
                    spaceCounter++;
                }
                if (spaceCounter == columns - 1) encryptStr += ' ';
            }

            return encryptStr;
        }

        public static string Decrypt(this string encryptStr)
        {
            if (encryptStr == null || encryptStr.Length == 0) throw new ArgumentNullException();
            if (encryptStr == _str) return encryptStr;

            encryptStr = encryptStr.Trim();
            string decryptStr = "";
            int key = (int)Math.Ceiling((double)encryptStr.Length / _key);

            for (int i = 0; i < key; i++)
            {
                for (int j = i; j < encryptStr.Length; j += key)
                {
                    decryptStr += encryptStr[j];
                }
            }

            return decryptStr.Trim();
        }
    }
}
