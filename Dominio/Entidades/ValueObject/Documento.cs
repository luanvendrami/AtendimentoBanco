using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.ValueObject
{
    public class Documento : ValueObject
    {
        public string Numero { get; private set; }
        public ETipoDocumento Tipo { get; private set; }

        public Documento(string numero, ETipoDocumento tipo)
        {
            Numero = numero;
            Tipo = tipo;
        }

    }
}
