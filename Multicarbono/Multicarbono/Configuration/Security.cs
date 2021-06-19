using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Multicarbono.Configuration
{
    public class Security
    {
        readonly IConfiguration configuration;

        public Security(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string Encrypt(string clearText)
        {
            if (clearText == null) clearText = "";

            string securityKey = this.configuration.GetValue<String>("EncriptKey");

            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(securityKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
    }
}