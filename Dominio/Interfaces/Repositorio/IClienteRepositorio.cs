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
        Cliente ValidaBancoCliente(string cpf, string rg);
        Cliente RetornaClientId(int id);
        Cliente ConsultaId(int id);
        List<Cliente> RetornaClientes();
        Cliente ConsultaPorNome(string nome, string cpf, string rg);
    }
}
