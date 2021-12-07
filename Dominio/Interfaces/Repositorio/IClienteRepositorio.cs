using Dominio.Entidades;
using Dominio.Interfaces.Repositorio.BaseRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorio
{
    public interface IClienteRepositorio : IBaseRepositorio<Cliente>
    {
        Cliente RetornaClientId(int id);
        Cliente ConsultaId(int id);
        List<Cliente> RetornaClientes();
    }
}
