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

        public static string ValidaTelefone(string numeroTelefone)
        {
            var telefone = Regex.Match(numeroTelefone, @"^(\+[0-9]{9})$").Success;
            return telefone.ToString();
        }
    }
}
