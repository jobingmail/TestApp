using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncDec
{
    public class AppHelper
    {
        public static string EncryptString(string strEncrypted)
        {
            if (string.IsNullOrEmpty(strEncrypted)) { return string.Empty; }

            try
            {
                byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(strEncrypted);
                string encryptedConnectionString = Convert.ToBase64String(b);
                return encryptedConnectionString;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// returns Decrypted text
        /// </summary>
        /// <param name="encrString"></param>
        /// <returns></returns>
        public static string DecryptString(string encrString)
        {
            if (string.IsNullOrEmpty(encrString)) { return string.Empty; }

            try
            {
                byte[] b = Convert.FromBase64String(encrString);
                string decryptedConnectionString = System.Text.ASCIIEncoding.ASCII.GetString(b);
                return decryptedConnectionString;
            }
            catch
            {
                throw;
            }
        }

    }
}
