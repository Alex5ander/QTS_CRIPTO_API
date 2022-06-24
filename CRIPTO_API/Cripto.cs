using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CRIPTO_API
{
    public class Cripto
    {
        const string chave = "12345";

        public static string Codificar(string texto)
        {
            byte[] Results;
            UTF8Encoding UTF8 = new UTF8Encoding();
            MD5CryptoServiceProvider Provedor = new MD5CryptoServiceProvider();
            byte[] TDESKey = Provedor.ComputeHash(UTF8.GetBytes(chave));
            TripleDESCryptoServiceProvider TDESAlgoritmo = new TripleDESCryptoServiceProvider();
            TDESAlgoritmo.Key = TDESKey;
            TDESAlgoritmo.Mode = CipherMode.ECB;
            TDESAlgoritmo.Padding = PaddingMode.PKCS7;
            byte[] DataToEncrypt = UTF8.GetBytes(texto);
            try
            {
                ICryptoTransform Encryptor = TDESAlgoritmo.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }
            finally
            {

                TDESAlgoritmo.Clear();
                Provedor.Clear();
            }

            return Convert.ToBase64String(Results);
        }
    }
}
