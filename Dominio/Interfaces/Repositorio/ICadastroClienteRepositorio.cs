using Dominio.Entidades;
using Dominio.Interfaces.Repositorio.BaseRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorio
{
    public interface ICadastroClienteRepositorio : IBaseRepositorio<DadosCliente>
    {
        IEnumerable<DadosCliente> RetornaClientes();
        IEnumerable<DadosCliente> RetornaNomeCliente(string nome);
        DadosCliente RetornaClientId(int id);
    }
}
