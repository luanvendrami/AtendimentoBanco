using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class PagamentosCliente
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

        public PagamentosCliente(byte formaPagamento, bool confirmadoPagamento, decimal valorPagamentoAgendado, DateTime dataPagamentoAgendado, decimal valorPagamento, DateTime dataPagamento, decimal valorMulta, decimal valorDesconto)
        {
            FormaPagamento = formaPagamento;
            ConfirmadoPagamento = confirmadoPagamento;
            ValorPagamentoAgendado = valorPagamentoAgendado;
            DataPagamentoAgendado = dataPagamentoAgendado;
            ValorPagamento = valorPagamento;
            DataPagamento = dataPagamento;
            ValorMulta = valorMulta;
            ValorDesconto = valorDesconto;
            Validacao();
        }
        public PagamentosCliente()
        {

        }

        public bool Validacao()
        {
            if (!string.IsNullOrEmpty(FormaPagamento.ToString()) && !string.IsNullOrEmpty(ConfirmadoPagamento.ToString()) && !string.IsNullOrEmpty(ValorPagamentoAgendado.ToString()) && !string.IsNullOrEmpty(ValorPagamento.ToString()) && !string.IsNullOrEmpty(DataPagamento.ToString()) && !string.IsNullOrEmpty(ValorMulta.ToString()) && !string.IsNullOrEmpty(ValorDesconto.ToString()))
                return true;
            return false;
        }
    }
}
