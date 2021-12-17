using Dominio.Entidades.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class PagamentoMercadoPago : Pagamento
    {
        public string CodigoTransacao { get; private set; }
        public  PagamentoMercadoPago(
            string codigoTransacao, 
            DateTime dataPagemento, 
            DateTime dataVencimento, 
            decimal total, 
            decimal totalPago, 
            string proprietarioPagamento,
            Documento documento,
            Endereco enderecoCobranca,
            Email email)
            : base(dataVencimento,
                  total,
                  totalPago,
                  proprietarioPagamento,
                  documento,
                  enderecoCobranca,
                  email )
        {
            CodigoTransacao = codigoTransacao;
        }
    }
}
