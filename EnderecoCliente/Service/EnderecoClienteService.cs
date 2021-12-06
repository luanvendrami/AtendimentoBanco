using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Service;
using Dominio.Modelos;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnderecoCliente.Service
{
    public class EnderecoClienteService : IEnderecoClienteService
    {
        private readonly IEnderecoClienteRepositorio _enderecoClienteRepositorio;

        public EnderecoClienteService(IEnderecoClienteRepositorio enderecoClienteRepositorio)
        {
            _enderecoClienteRepositorio = enderecoClienteRepositorio;
        }

        public string CadastroEndereco(EnderecoDto dto)
        {
            var enderecoClienteEntidade = new EnderecoDoCliente(dto.Uf, dto.Cidade, dto.Bairro, dto.Rua, dto.NumeroResidencia, dto.Complemento);
            if (enderecoClienteEntidade.Validacao())
            {
                _enderecoClienteRepositorio.Adicionar(enderecoClienteEntidade);
                return $"Endereço cadastrado com sucesso!";
            }
            else
            {
                return $"Endereço não foi cadastrado, verifique as informações!";
            }
        }

        public EnderecoDoCliente RetornaPorId(int id)
        {
            var retorno = _enderecoClienteRepositorio.RetornaEnderecoId(id);
            return retorno;
        }

        public string AtualizarEndereco(int id, EnderecoDto dto)
        {
            var consultaRepositorio = _enderecoClienteRepositorio.RetornaEnderecoId(id);
            if (consultaRepositorio.Id == id)
            {
                var endertecoCliente = new EnderecoDoCliente(dto.Uf, dto.Cidade, dto.Bairro, dto.Rua, dto.NumeroResidencia, dto.Complemento);
                consultaRepositorio = endertecoCliente;
                _enderecoClienteRepositorio.Atualizar(consultaRepositorio);
            }
            return $"Alterado com sucesso!";
        }

        public string DeletarEndereco(int id)
        {
            var consultaRepositorio = _enderecoClienteRepositorio.RetornaEnderecoId(id);
            _enderecoClienteRepositorio.Remover(consultaRepositorio.Id);
            return $"Deletado com sucesso!";
        }
    }
}
