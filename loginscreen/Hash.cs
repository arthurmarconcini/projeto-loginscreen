using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace loginscreen
{
    public class Hash
    {
        public string CriptografarSenha(string senha)
        {
            var valorCodificado = Encoding.UTF8.GetBytes(senha);
            var senhaCriptografada = MD5.Create().ComputeHash(valorCodificado);

            StringBuilder stringBuilder = new StringBuilder();

            for (int count = 0; count < senhaCriptografada.Length; count++)
            {
                stringBuilder.Append(senhaCriptografada[count].ToString("X2"));
            }


            return stringBuilder.ToString();
        }

        public bool CompararSenha(string senhaDigitada, string SenhaCadastrada)
        {
            var senhaDigitadaCripto = CriptografarSenha(senhaDigitada);
            return senhaDigitadaCripto == SenhaCadastrada;
        }
    }
}
