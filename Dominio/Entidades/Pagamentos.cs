using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Pagamentos
    {
        public int Id { get; set; }
        public byte FormaPagamento { get; set; }
        public bool ConfirmadoPagamento { get; set; }
        public decimal ValorPagamentoAgendado { get; set; }
        public DateTime DataPagamentoAgendado { get; set; }
        public decimal ValorPagamento { get; set; }
        public DateTime DataPagamento { get; set; }
        public decimal ValorMulta { get; set; }
        public decimal ValorDesconto { get; set; }
    }
}
