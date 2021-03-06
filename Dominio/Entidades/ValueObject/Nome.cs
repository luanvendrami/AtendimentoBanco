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
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            ValidaNulo();
        }

        public bool ValidaNulo()
        {
            if (!string.IsNullOrEmpty(PrimeiroNome) && PrimeiroNome.Length >= 4 && !string.IsNullOrEmpty(Sobrenome) && Sobrenome.Length >= 4)
                return true;
            return false;
        }

    }
}
