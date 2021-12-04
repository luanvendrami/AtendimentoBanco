using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Service;
using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.Service
{
    public class CadastroClienteService : ICadastroClienteService
    {
        private readonly ICadastroClienteRepositorio _informacaoClienteRepositorio;

        public CadastroClienteService(ICadastroClienteRepositorio informacaoClienteRepositorio)
        {
            _informacaoClienteRepositorio = informacaoClienteRepositorio;
        }

        public string CadastroCliente(ClienteDto dto)
        {
            var entidadeInformacaoCliente = new DadosCliente(dto.NomeCompleto, dto.Cpf, dto.Rg, dto.DataNascimento);
            if (entidadeInformacaoCliente.Validacao())
            {
                _informacaoClienteRepositorio.Adicionar(entidadeInformacaoCliente);
                return $"Cliente cadastrado com sucesso!";
            }
            else
            {
                return $"Cliente não foi cadastrado, verifique as informações!";
            } 
        }

        public DadosCliente RetornaPorId(int id)
        {
            var consultaRepositorio = _informacaoClienteRepositorio.RetornaClientId(id);
            return consultaRepositorio;
        }

        public string AtualizarDados(int id, ClienteDto dto)
        {
            var consultaRepositorio = _informacaoClienteRepositorio.RetornaClientId(id);
            if (consultaRepositorio.Id == id)
            {    
                var dadosCliente = new DadosCliente(consultaRepositorio.Id, dto.NomeCompleto, dto.Cpf, dto.Rg, dto.DataNascimento);
                consultaRepositorio = dadosCliente;
                _informacaoClienteRepositorio.Atualizar(consultaRepositorio);
            }
            return $"Alterado com sucesso!";
        }

        public string DeletarDados(int id)
        {
            var consultaRepositorio = _informacaoClienteRepositorio.RetornaClientId(id);
            _informacaoClienteRepositorio.Remover(consultaRepositorio.Id);
            return $"Deletado com sucesso!";
        }
    }
}
