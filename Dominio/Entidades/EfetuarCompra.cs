using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class EfetuarCompra
    {
        public int Id { get; set; }
        public int Parcelamento { get; set; }
        public decimal ValorCompra { get; set; }
        public DateTime DataCompra { get; set; }
        public DateTime VencimentoParcelas { get; set; }
        public decimal JurosValorParcelado { get; set; }
        public int IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public virtual Cliente CompraNavegation { get; set; }

        public EfetuarCompra(int idCliente,int parcelamento, decimal valorCompra)
        {
            IdCliente = idCliente;
            Parcelamento = parcelamento;
            ValorCompra = valorCompra;
            DataCompra = DateTime.Now;
            VencimentoParcelas = DateTime.Now .AddDays(30);
            JurosValorParcelado = 0;
        }

        public EfetuarCompra()
        {

        }
    }
}
