using Dominio.Entidades;
using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Service
{
    public interface IEnderecoClienteService
    {
        string CadastroEndereco(EnderecoDto dto);
        EnderecoDoCliente RetornaPorId(int id);
        string AtualizarEndereco(int id, EnderecoDto dto);
    }
}
