using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Service
{
    public interface IPagamentoService
    {
        string SalvaTaxas(EncargosDto dto);
    }
}
