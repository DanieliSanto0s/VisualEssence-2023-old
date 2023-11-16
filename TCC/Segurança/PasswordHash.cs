using System.Security.Cryptography;
using System.Text;

namespace Tcc.Segurança
{
    public static class PasswordHash
    {
        public static string CriarHash(this string valor)
        {
            using (var hash = SHA256.Create())
            {
                var encoding = new ASCIIEncoding();
                var array = encoding.GetBytes(valor);

                array = hash.ComputeHash(array);

                var hashcod = new StringBuilder();

                foreach (var item in array)
                {
                    hashcod.Append(item.ToString("x2"));
                }

                return hashcod.ToString();
            }
        }
    }
}