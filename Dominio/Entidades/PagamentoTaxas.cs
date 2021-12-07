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

        public PagamentoTaxas(decimal juros, decimal desconto)
        {
            Juros = juros;
            Desconto = desconto;
            Validacao();
        }

        public PagamentoTaxas()
        {

        }

        public bool Validacao()
        {
            if (!string.IsNullOrEmpty(Juros.ToString()) && !string.IsNullOrEmpty(Desconto.ToString()))
                return true;
            return false;
        }
    }
}
