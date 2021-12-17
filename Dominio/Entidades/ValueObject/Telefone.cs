using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dominio.Entidades.ValueObject
{
    public class Telefone : ValueObject
    {
        public Telefone(string numeroTelefone, ETipoTelefone tipoTelefone)
        {
            NumeroTelefone = ValidaTelefone(numeroTelefone);
            TipoTelefone = tipoTelefone;
        }

        public string NumeroTelefone { get; private set; }
        public ETipoTelefone TipoTelefone { get; private set; }

        public bool ValidaTelefone(string numeroTelefone)
        {
            numeroTelefone = numeroTelefone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
            if (numeroTelefone.Length == 11) return true;
            return false;       
        }
    }
}
