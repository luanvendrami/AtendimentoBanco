using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.ValueObject
{
    public class Nome : ValueObject
    {
        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }
        public Nome(string primeiroNome, string sobrenome)
        {
            PrimeiroNome = ValidaNome(primeiroNome);
            Sobrenome = ValidaSobrenome(sobrenome);
        }

        public static string ValidaNome(string primeiroNome)
        {
            if (string.IsNullOrEmpty(primeiroNome) && primeiroNome.Length > 4)
                return primeiroNome;
            return "Erro ao cadastrar o nome.";
        }

        public static string ValidaSobrenome(string sobrenome)
        {
            if (string.IsNullOrEmpty(sobrenome) && sobrenome.Length > 4)
                return sobrenome;
            return "Erro ao cadastrar o sobrenome";
        }
    }
}
