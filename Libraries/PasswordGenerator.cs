using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.DataFormats;

namespace FileManager.Packages
{
    public class PasswordGenerator
    {
        private static readonly Random random = new Random();
        private static string GenerateRandomnNumber(int Length)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for(int i=0;i<Length;i++)
            {
                stringBuilder.Append(random.Next(0, 9).ToString());
            }
            return stringBuilder.ToString();
        }
        public static string GenerateRandomnUpperText(int Length)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < Length; i++)
            {
                stringBuilder.Append((char)random.Next(65, 91));
            }
            return stringBuilder.ToString();
        }
        public static string GenerateRandomnLowerText(int Length)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < Length; i++)
            {
                stringBuilder.Append((char)random.Next(97, 123));
            }
            return stringBuilder.ToString();
        }
        public static string GenerateRandomnSymbols(int Length)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < Length; i++)
            {             
                stringBuilder.Append((char)random.Next(33, 48));
            }
            return stringBuilder.ToString();
        }
        public static string GenerateRandomPassword(int Length)
        {
            string Numbers = "0123456789";
            string Uppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string Lowers = "abcdefghijklmnopqrstuvwxyz";
            string Symbols = "!@#$%^&*()-_=+[]{};:,.<>?/";
            string format = Numbers + Uppers + Lowers + Symbols;
            StringBuilder password = new StringBuilder();
            for (int i = 0; i < Length; i++)
            {
                int num = random.Next(0, format.Length);
                password.Append(format[num]);
            }
            return password.ToString();
        }
        public static string GenerateRandomCombinedPassword(int Length,bool isuppers,bool islowers,bool isnumbers,bool issymbols)
        {
            string Numbers = "0123456789";
            string Uppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string Lowers = "abcdefghijklmnopqrstuvwxyz";
            string Symbols = "!@#$%^&*()-_=+[]{};:,.<>?/";
            StringBuilder format = new StringBuilder("");
            if (isuppers)
            {
                format.Append(Uppers);
            }
            if (islowers)
            {
                format.Append(Lowers);
            }
            if (isnumbers)
            {
                format.Append(Numbers);
            }
            if (issymbols)
            {
                format.Append(Symbols);
            }
            if(format.Length==0)
            {
                return GenerateRandomnNumber(Length);
            }
                StringBuilder password = new StringBuilder();
            for (int i = 0; i < Length; i++)
            {
                int num = random.Next(0, format.Length);
                password.Append(format[num]);
            }
            return password.ToString();


        }

        public static string Generate128bitkey()
        {
            RandomNumberGenerator generator =  RandomNumberGenerator.Create();
            byte[] random = new byte[16];
            generator.GetBytes(random);
            return Convert.ToHexString(random);
        }

        public static string GenerateHash(string plaintext)
        {
            SHA256 sHA = SHA256.Create();
            return Convert.ToBase64String(sHA.ComputeHash(Encoding.UTF8.GetBytes(plaintext)));
        }

    }
}
