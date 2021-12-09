using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Service;
using Dominio.Modelos;
using System;
using System.Collections.Generic;

namespace CadastroCliente.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        private readonly IEnderecoRepositorio _enderecoRepositorio;
        private readonly IPagamentoRepositorio _pagamentoRepositorio;

        public ClienteService(IClienteRepositorio clienteRepositorio, IEnderecoRepositorio enderecoRepositorio, IPagamentoRepositorio pagamentoRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
            _enderecoRepositorio = enderecoRepositorio;
            _pagamentoRepositorio = pagamentoRepositorio;
        }

        //Metodo para cadastro de clientes.
        public string CadastroCliente(DadosDto dto)
        {
            var consultaClienteExistente = _clienteRepositorio.ValidaBancoCliente(dto.Cpf, dto.Rg);
            if(consultaClienteExistente == null)
            {
                var entidadeCliente = new Cliente(dto.NomeCompleto, dto.Cpf, dto.Rg, dto.DataNascimento);
                var entidadeEndereco = new Endereco(entidadeCliente, dto.Uf, dto.Cidade, dto.Bairro, dto.Rua, dto.NumeroResidencia, dto.Complemento);
                var entidadePagamento = new Pagamento(entidadeCliente, dto.FormaPagamento);
                if (entidadeCliente.Validacao() && entidadeEndereco.Validacao() && entidadePagamento.Validacao())
                {
                    _clienteRepositorio.Adicionar(entidadeCliente);
                    _enderecoRepositorio.Adicionar(entidadeEndereco);
                    _pagamentoRepositorio.Adicionar(entidadePagamento);

                    return $"Cliente cadastrado com sucesso!";
                }
                else
                {
                    return $"Cliente não foi cadastrado, verifique as informações!";
                }
            }
            return $"Cliente já cadastrado!";
        }

        public List<Cliente> RetornaTodosClientes()
        {
            var consultaRepositorio = _clienteRepositorio.RetornaClientes();
            return consultaRepositorio;
        }

        //Metodo que retorna o Id pesquisado.
        public Cliente RetornaPorId(int id)
        {
            var consultaRepositorio = _clienteRepositorio.ConsultaId(id);
            return consultaRepositorio;
        }

        //Metodo que atualiza os dados com o Id fornecido.
        public string AtualizarDados(int id, DadosDto dto)
        {
            var consultaRepositorio = _clienteRepositorio.RetornaClientId(id);
            if (consultaRepositorio.Id == id)
            {    
                var dadosCliente = new Cliente(consultaRepositorio.Id, dto.NomeCompleto, dto.Cpf, dto.Rg, dto.DataNascimento);
                consultaRepositorio = dadosCliente;
                var entidadeEndereco = new Endereco(consultaRepositorio.Id, dto.Uf, dto.Cidade, dto.Bairro, dto.Rua, dto.NumeroResidencia, dto.Complemento);
                consultaRepositorio.Endereco = entidadeEndereco;
                var entidadePagamento = new Pagamento(consultaRepositorio.Id, dto.FormaPagamento);
                consultaRepositorio.Pagamentos = entidadePagamento;

                _clienteRepositorio.Atualizar(consultaRepositorio);
                _enderecoRepositorio.Atualizar(entidadeEndereco);
                _pagamentoRepositorio.Atualizar(entidadePagamento);
            }
            return $"Alterado com sucesso!";
        }

        //Metodo que exclui o cliente com o Id fornecido.
        public string DeletarDados(int id)
        {
            var consultaRepositorio = _clienteRepositorio.RetornaClientId(id);
            _clienteRepositorio.Remover(consultaRepositorio.Id);
            return $"Deletado com sucesso!";
        }
    }
}
