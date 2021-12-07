using Dominio.Entidades;
using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Service
{
    public interface IClienteService
    {
        string CadastroCliente(BancoDto dto);
        Cliente RetornaPorId(int id);
        string AtualizarDados(int id, BancoDto dto);
        string DeletarDados(int id);
        List<Cliente> RetornaTodosClientes();
    }
}
