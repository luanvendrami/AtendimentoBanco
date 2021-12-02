using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorio
{
    public interface IPagamentosRepositorio
    {
        Pagamentos RetornaClientId(int id);
    }
}
