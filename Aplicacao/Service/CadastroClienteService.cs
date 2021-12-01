using Dominio.Entidades;
using Dominio.Interfaces.Aplicações;
using Dominio.Interfaces.Repositorio;
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
        private readonly IInformacaoClienteRepositorio _informacaoClienteRepositorio;

        public CadastroClienteService(IInformacaoClienteRepositorio informacaoClienteRepositorio)
        {
            _informacaoClienteRepositorio = informacaoClienteRepositorio;
        }

        public string CadastroCliente(ClienteDto dto)
        {
            var entidadeInformacaoCliente = new InformacaoCliente(dto.Id, dto.NomeCompleto, dto.Cpf, dto.Rg, dto.DataNascimento, dto.Cep);
            if (entidadeInformacaoCliente.Validacao())
            {
                _informacaoClienteRepositorio.Adicionar(entidadeInformacaoCliente);
                _informacaoClienteRepositorio.SalvarAlteracao();
                return $"Cliente cadastrado com sucesso!";
            }
            else
            {
                return $"Cliente não foi cadastrado, verifique as informações!";
            } 
        }
    }
}
