using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Compra
    {
        public int Id { get; set; }
        public int Parcelamento { get; set; }
        public decimal ValorCompra { get; set; }
        public DateTime DataCompra { get; set; }
        public DateTime VencimentoParcelas { get; set; }
        public decimal JurosValorParcelado { get; set; }
        public int IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public virtual List<Cliente> CompraNavegation { get; set; }


    }
}
