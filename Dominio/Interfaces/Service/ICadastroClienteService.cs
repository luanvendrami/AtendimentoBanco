using Dominio.Entidades;
using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Service
{
    public interface ICadastroClienteService
    {
        string CadastroCliente(ClienteDto dto);
        DadosCliente RetornaPorId(int id);
        string AtualizarDados(int id, ClienteDto dto);
        string DeletarDados(int id);
    }
}
