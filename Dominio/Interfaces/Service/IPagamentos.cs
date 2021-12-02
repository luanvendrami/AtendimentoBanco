using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Service
{
    public interface IPagamentos
    {
        string CadastroPagamentos(PagamentoDto dto);
    }
}
