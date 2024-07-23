using System;
using System.Security.Cryptography;
using System.Text;

namespace SecureCrypt
{
    public class SCWindows
    {
        public static byte[] EncryptData(string dataToEncrypt, byte[] optionalEntropy = null)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(dataToEncrypt);
            byte[] encryptedData = ProtectedData.Protect(dataBytes, optionalEntropy, DataProtectionScope.CurrentUser);
            return encryptedData;
        }

        public static string DecryptData(byte[] encryptedData, byte[] optionalEntropy = null)
        {
            byte[] decryptedData = ProtectedData.Unprotect(encryptedData, optionalEntropy, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(decryptedData);
        }
    }
}
