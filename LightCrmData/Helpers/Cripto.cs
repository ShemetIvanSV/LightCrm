using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace LightCrmData.Helpers
{
    public static class Cripto
    {
        public static string Sha256(string randomString)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}