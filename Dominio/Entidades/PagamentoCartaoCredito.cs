using Dominio.Entidades.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class PagamentoCartaoCredito : Pagamento
    {
        public string NomeCartao { get; private set; }
        public string NumeroCartao { get; private set; }
        public string NumeroUltimaTransacao { get; private set; }
        public PagamentoCartaoCredito(
            string nomeCartao,
            string numeroCartao,
            string numeroUltimaTransacao,
            DateTime dataPagemento,
            DateTime dataVencimento,
            decimal total,
            decimal totalPago,
            string proprietarioPagamento,
            Documento documento,
            Endereco enderecoCobranca,
            Email email)
            : base
            (dataVencimento,
                  total,
                  totalPago,
                  proprietarioPagamento,
                  documento,
                  enderecoCobranca,
                  email)
        {
            NomeCartao = nomeCartao;
            NumeroCartao = numeroCartao;
            NumeroUltimaTransacao = numeroUltimaTransacao;
            AddDescontoCartaoCredito();
            AddAcrescimoCartaoCredito();
        }

        public bool AddDescontoCartaoCredito()
        {
            if (DataVencimento < DataPagemento)
            {
                //CalculoDesconto();
                return true;
            }
            return false;
        }

        public decimal CalculoDesconto()
        {
            if (Total != 0)
            {
                var data = DataPagemento.Subtract(DataVencimento).Days;
                var valor_final = ((double)Total * 0.03) * data;
                decimal valor = Total - (decimal)valor_final;
                return valor;
            }
            return 0;
        }

        public bool AddAcrescimoCartaoCredito()
        {

            if (DataPagemento > DataVencimento)
            {
                //CalculoAcrescimo();
                return true;
            }
            return false;
        }

        public decimal CalculoAcrescimo()
        {
            if (Total != 0)
            {
                var data = DataVencimento.Subtract(DataPagemento).Days + 1;
                var valor_final = ((double)Total * 0.03) * data + (double)Total;
                return (decimal)valor_final;
            }
            return 0;
        }
    }
}
