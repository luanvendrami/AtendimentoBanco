using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Pagamento
    {  
        public int Id { get; private set; }
        public int FormaPagamento { get; private set; }
        public int IdCliente { get; private set; }

#nullable enable
        public decimal? ValorPago { get; private set; }

        public DateTime? DataVencimento { get; private set; }

        //DATA DE COBRANÇA
        public DateTime? DataPagamento { get; private set; }
        public decimal? Juros { get; private set; }
        public decimal? Desconto { get; private set; }
        public decimal? ValorPagamentoComReajustes { get; private set; }
#nullable disable

        [ForeignKey("IdCliente")]
        public virtual Cliente PagamentoNavegation { get; set; }

        //Construtor usada para o metodo de cadastro de clientes.
        public Pagamento(Cliente navegation, TipoPagamento formaPagamento)
        {
            PagamentoNavegation = navegation;
            FormaPagamento = (int)formaPagamento;  
            Validacao();
        }

        //Construtor usada para o metodo atualização de cadastro para clientes.
        public Pagamento(int idCliente, TipoPagamento formaPagamento)
        {
            IdCliente = idCliente;
            FormaPagamento = (int)formaPagamento;
            Validacao();
        }

        public Pagamento()
        {

        }

        public Pagamento(int idCliente, decimal valorPago, TipoPagamento formaPagamento, DateTime vencimento)
        {
            IdCliente = idCliente;
            ValorPago = valorPago;            
            DataPagamento = DateTime.Now;
            Juros = PagamentoAtrasado(formaPagamento, (DateTime)DataPagamento , vencimento, valorPago, 0);
            Desconto = Desconto = PagamentoAdiantado(formaPagamento, (DateTime)DataPagamento, vencimento, valorPago, 0);
            ValorPagamentoComReajustes = ValoresFinais(0, (decimal)Juros, (decimal)Desconto);
        }

        public Pagamento(int idCliente, int formaPagamento, decimal valorPago)
        {
            IdCliente = idCliente;
            FormaPagamento = formaPagamento;
            ValorPago = valorPago;
            DataVencimento = DateTime.Now.AddDays(30);
        }

        public static decimal PagamentoAtrasado(TipoPagamento formaPagamento, DateTime dataPagamento, DateTime vencimento, decimal valorPago, decimal juros)
        {
            
            if (dataPagamento > vencimento)
            {
                var data = dataPagamento.Subtract(vencimento).TotalDays;
                double porcentagem;               
                if (data != 0)
                {
                    switch (formaPagamento)
                    {
                        case (TipoPagamento)1: 
                            porcentagem = 0.1 * (double)valorPago;
                            porcentagem *= data;
                            juros = (decimal)porcentagem;
                            return juros;
                        case (TipoPagamento)2:
                            porcentagem = 0.03 * (double)valorPago;
                            porcentagem *= data;
                            juros = (decimal)porcentagem;
                            return juros;
                        case (TipoPagamento)3:
                            porcentagem = 0.03 * (double)valorPago;
                            porcentagem *= data;
                            juros = (decimal)porcentagem;
                            return juros;
                        case (TipoPagamento)4:
                            porcentagem = 0.02 * (double)valorPago;
                            porcentagem *= data;
                            juros = (decimal)porcentagem;
                            return juros;
                        case (TipoPagamento)5:
                            porcentagem = 0.02 * (double)valorPago;
                            porcentagem *= data;
                            juros = (decimal)porcentagem;
                            return juros;                            
                        case (TipoPagamento)6:
                            porcentagem = 0.02 * (double)valorPago;
                            porcentagem *= data;
                            juros = (decimal)porcentagem;
                            return juros;
                    }
                }               
            }
            return juros;
        }

        public static decimal PagamentoAdiantado(TipoPagamento formaPagamento, DateTime dataPagamento, DateTime vencimento, decimal valorPago, decimal desconto)
        {
            if(dataPagamento < vencimento)
            {
                var data = vencimento.Subtract(dataPagamento).TotalDays;
                double porcentagem;
                switch (formaPagamento)
                {
                    case (TipoPagamento)1:
                        porcentagem = 0.0001 * (double)valorPago;
                        porcentagem *= data;
                        desconto = (decimal)porcentagem;
                        return desconto;
                    case (TipoPagamento)2:
                        porcentagem = 0.01 * (double)valorPago;
                        porcentagem *= data;
                        desconto = (decimal)porcentagem;
                        return desconto;
                    case (TipoPagamento)3:
                        porcentagem = 0.1 * (double)valorPago;
                        porcentagem *= data;
                        desconto = (decimal)porcentagem;
                        return desconto;
                    case (TipoPagamento)4:
                        porcentagem = 0.1 * (double)valorPago;
                        porcentagem *= data;
                        desconto = (decimal)porcentagem;
                        return desconto;
                    case (TipoPagamento)5:
                        porcentagem = 0.05 * (double)valorPago;
                        porcentagem *= data;
                        desconto = (decimal)porcentagem;
                        return desconto;
                    case (TipoPagamento)6:
                        porcentagem = 0.0001 * (double)valorPago;
                        porcentagem *= data;
                        desconto = (decimal)porcentagem;
                        return desconto;
                }   
            }
            return desconto;
        }

        public static decimal ValoresFinais(decimal valorPagamentoComReajustes, decimal juros, decimal desconto)
        {
            if(juros != 0)
            {
                valorPagamentoComReajustes += juros;
                return valorPagamentoComReajustes;
            }else if(desconto != 0)
            {
                valorPagamentoComReajustes -= desconto;
                return valorPagamentoComReajustes;
            }
            return valorPagamentoComReajustes;
        }
        public bool Validacao()
        {
            if (!string.IsNullOrEmpty(FormaPagamento.ToString()))
                return true;
            return false;
        }

    }
}
