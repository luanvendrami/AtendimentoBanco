using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Enums
{
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TipoPagamento
    {
        [Description("Sem forma de pagamento")]
        Sem_Pagamento = 0,
        [Description("Cartão de crédito")]
        Carttao_Credito = 1,
        [Description("Cartão de débito")]
        Cartao_Debito = 2,
        [Description("Boleto bancário")]
        Boleto = 3,
        [Description("Pix")]
        Pix = 4,
        [Description("TED")]
        Ted = 5,
        [Description("Cheque")]
        Cheque = 5
    }
}
