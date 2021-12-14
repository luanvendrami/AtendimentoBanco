using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos
{
    public class EfetuarCompraDto
    {
        public int Parcelamento { get; set; }
        public decimal ValorCompra { get; set; }
        public string Cpf { get; set; }
    }
}
