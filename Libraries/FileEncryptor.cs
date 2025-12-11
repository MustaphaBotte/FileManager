using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using Aes = System.Security.Cryptography.Aes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FileManager.Packages
{
    public class PasswordManager
    {
        public static string SaltPath = "../../../resources/Salt.txt";
        public static string HashPath = "../../../resources/Hash.txt";

        private static byte[] GetCombinedHashAndSalt(byte[] Hash, byte[] Salt)
        {
            byte[] CombinedHash_Salt = new byte[Salt.Length + Hash.Length];
            Array.Copy(Salt, 0, CombinedHash_Salt, 0, Salt.Length);
            Array.Copy(Hash, 0, CombinedHash_Salt, Salt.Length, Hash.Length);
            return CombinedHash_Salt;
        }
        private static byte[] GenerateSalt()
        {
            byte[] Salt = new byte[16];
            RandomNumberGenerator rnd = RandomNumberGenerator.Create();
            rnd.GetBytes(Salt);
            return Salt;
        }
        internal static byte[] GetBytesFromFile(string Path)
        {
            try
            {
                byte[] salt = File.ReadAllBytes(Path);
                return salt;
            }
            catch
            {
                return new byte[0];
            }
        }
        private static void SaveBytesToFile(byte[] bytes,string Path)
        {
            try
            {
                File.WriteAllBytes(Path, bytes);
                
            }
            catch
            {
               
            }
        }       
        private static byte[] GenerateHash(string Password)
        {
            byte[] Userpass = Encoding.UTF8.GetBytes(Password);
            byte[] Salt = GenerateSalt();
            byte[] FinalPassArray = new byte[Userpass.Length + Salt.Length];
            Array.Copy(Salt, 0, FinalPassArray, 0, Salt.Length);
            Array.Copy(Userpass, 0, FinalPassArray, Salt.Length, Userpass.Length);

            byte[] Hash = SHA256.Create().ComputeHash(FinalPassArray);

            SaveBytesToFile(Salt,SaltPath);
            SaveBytesToFile(Hash, HashPath);
            return Hash;
        }


        public static bool ValidatePasswordText(string Pass)
        {
            byte[] Salt = GetBytesFromFile(SaltPath);
            byte[] Hash = GetBytesFromFile(HashPath);

            byte[] Userpass = Encoding.UTF8.GetBytes(Pass);
            byte[] FinalPassArray = new byte[Salt.Length + Userpass.Length];

            Array.Copy(Salt, 0, FinalPassArray, 0, Salt.Length);
            Array.Copy(Userpass, 0, FinalPassArray, Salt.Length, Userpass.Length);

            byte[] ComputedHash = SHA256.Create().ComputeHash(FinalPassArray);           
            return Convert.ToBase64String(ComputedHash) ==Convert.ToBase64String(Hash);
        }
        public static bool Validate128BitKey(byte[] key)
        {
            byte[] Salt = GetBytesFromFile(SaltPath);
            byte[] Hash = GetBytesFromFile(HashPath);
            string hashstring = Convert.ToHexString(Hash.Take(16).ToArray());
            string UserKey    = Convert.ToHexString(key);
            return UserKey == hashstring;
        }
       
        public static string Generate128BitKey(string Pass)
        {
           return Convert.ToHexString(GenerateHash(Pass).Take(16).ToArray());
        }
        public static string GenerateStrongPassword()
        {
            return PasswordGenerator.GenerateRandomPassword(16);
        }

    }
    public class FileEncryptor
    {
        public static bool EncryptFile(byte[] bitKey_128, string FilePath, string OutputPath)
        {
            try
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = bitKey_128;
                    byte[] IV = new byte[16];
                    RandomNumberGenerator.Create().GetBytes(IV);
                    aes.IV = IV;
                    using (FileStream InputStream = new FileStream(FilePath, FileMode.Open))
                    {
                        using (FileStream OutputStream = new FileStream(OutputPath, FileMode.Create))
                        {
                            OutputStream.Write(aes.IV, 0, aes.IV.Length);
                            using (ICryptoTransform cryptor = aes.CreateEncryptor())
                            {                               
                                using (CryptoStream cryptoStream = new CryptoStream(OutputStream, cryptor, CryptoStreamMode.Write))
                                {
                                    InputStream.CopyTo(cryptoStream);
                                }
                            }
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool DecryptFile(byte[] bitKey_128, string FilePath,string OutputPath)
        {
            try
            {
                using (Aes aes = Aes.Create())
                {

                    using (FileStream InputStream = new FileStream(FilePath, FileMode.Open))
                    {
                        aes.Key = bitKey_128;
                        byte[] IV = new byte[16];
                        InputStream.Read(IV, 0, 16);
                        aes.IV = IV;
                        using (FileStream OutputStream = new FileStream(OutputPath, FileMode.Create))
                        {
                            using (ICryptoTransform cryptor = aes.CreateDecryptor())
                            {
                                using (CryptoStream cryptoStream = new CryptoStream(InputStream, cryptor, CryptoStreamMode.Read))
                                {                                  
                                    cryptoStream.CopyTo(OutputStream);
                                }
                            }
                        }
                    }
                }
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public static byte[] GetTheStoredHash()
        {          
            byte[] Hash = PasswordManager.GetBytesFromFile(PasswordManager.HashPath);
            return Hash.Take(16).ToArray();
        }
    }





}
