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
        }
    }
}
