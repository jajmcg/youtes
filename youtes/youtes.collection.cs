using System;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Newtonsoft.Json;
namespace youtes
{
    public static class Strings
    {
        /// <summary>
        /// 
        /// /</summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsExit(this string value)
        {
            return new string[] { "exit", "exi", "ex", "x" }.Contains(value.ToLower());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsQuit(this string value)
        {
            return new string[] { "quit", "qui", "qu", "q" }.Contains(value.ToLower());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsYes(this string value)
        {
            return new string[] { "yes", "ye", "y" }.Contains(value.ToLower());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNo(this string value)
        {
            return new string[] { "no", "n" }.Contains(value.ToLower());
        }
    }
    public static class Crypto
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string EncryptStringJSON(this string value, string key)
        {
            var encrypted = new byte[0];

            return JsonConvert.SerializeObject(encrypted);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string DecryptStringJSON(this string value, string key)
        {
            try
            {
                byte[] encryptedData = JsonConvert.DeserializeObject<byte[]>(value);
                return "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 
        /// From: https://stackoverflow.com/questions/12657792/how-to-securely-save-username-password-local
        /// https://stackoverflow.com/users/1634846/akton
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public static byte[] Entropy(int size = 32)
        {
            try
            {
                byte[] entropy = new byte[size];  // define size of entropy based on parameter
                using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider()) // init random number generator
                {
                    rng.GetBytes(entropy); // populate
                }
                return entropy; // return
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
