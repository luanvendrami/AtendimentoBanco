using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class PagamentoTaxas
    {
        public int Id { get; private set; }
        public decimal Juros { get; private set; }
        public decimal Desconto { get; private set; }
        public int IdPagamento { get; private set; }

        public PagamentoTaxas(int id, decimal juros, decimal desconto, int idPagamento)
        {
            Id = id;
            Juros = juros;
            Desconto = desconto;
            IdPagamento = idPagamento;
        }

        public PagamentoTaxas()
        {

        }
    }
}
