using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Service;
using Dominio.Modelos;
       

namespace CadastroCliente.Service
{
    public class CadastroClienteService : ICadastroClienteService
    {
        private readonly ICadastroClienteRepositorio _informacaoClienteRepositorio;
        private readonly IEnderecoClienteRepositorio _enderecoClienteMapeamento;
        private readonly IPagamentosRepositorio _pagamentosRepositorio;

        public CadastroClienteService(ICadastroClienteRepositorio informacaoClienteRepositorio, IEnderecoClienteRepositorio enderecoClienteMapeamento, IPagamentosRepositorio pagamentosRepositorio)
        {
            _informacaoClienteRepositorio = informacaoClienteRepositorio;
            _enderecoClienteMapeamento = enderecoClienteMapeamento;
            _pagamentosRepositorio = pagamentosRepositorio;
        }

        public string CadastroCliente(ClienteDto dto)
        {
            var entidadeCliente = new DadosCliente(dto.NomeCompleto, dto.Cpf, dto.Rg, dto.DataNascimento);
            var entidadeEndereco = new EnderecoDoCliente(entidadeCliente, dto.Uf, dto.Cidade, dto.Bairro, dto.Rua, dto.NumeroResidencia, dto.Complemento);
            var entidadePagamento = new PagamentosCliente(entidadeCliente, dto.FormaPagamento, dto.ConfirmadoPagamento, dto.ValorPagamentoAgendado, dto.DataPagamentoAgendado, dto.ValorPagamento, dto.DataPagamento, dto.ValorMulta, dto.ValorDesconto);
            if (entidadeCliente.Validacao() && entidadeEndereco.Validacao() && entidadePagamento.Validacao())
            {
                _informacaoClienteRepositorio.Adicionar(entidadeCliente);
                _enderecoClienteMapeamento.Adicionar(entidadeEndereco);
                _pagamentosRepositorio.Adicionar(entidadePagamento);
                
                return $"Cliente cadastrado com sucesso!";
            }
            else
            {
                return $"Cliente não foi cadastrado, verifique as informações!";
            } 
        }

        public DadosCliente RetornaPorId(int id)
        {
            var consultaRepositorio = _informacaoClienteRepositorio.ConsultaId(id);
            return consultaRepositorio;
        }

        public string AtualizarDados(int id, ClienteDto dto)
        {
            var consultaRepositorio = _informacaoClienteRepositorio.RetornaClientId(id);
            if (consultaRepositorio.Id == id)
            {    
                var dadosCliente = new DadosCliente(consultaRepositorio.Id, dto.NomeCompleto, dto.Cpf, dto.Rg, dto.DataNascimento);
                consultaRepositorio = dadosCliente;
                var entidadeEndereco = new EnderecoDoCliente(consultaRepositorio.Id, dto.Uf, dto.Cidade, dto.Bairro, dto.Rua, dto.NumeroResidencia, dto.Complemento);
                consultaRepositorio.Endereco = entidadeEndereco;
                var entidadePagamento = new PagamentosCliente(consultaRepositorio.Id, dto.FormaPagamento, dto.ConfirmadoPagamento, dto.ValorPagamentoAgendado, dto.DataPagamentoAgendado, dto.ValorPagamento, dto.DataPagamento, dto.ValorMulta, dto.ValorDesconto);
                consultaRepositorio.Pagamentos = entidadePagamento;

                _informacaoClienteRepositorio.Atualizar(consultaRepositorio);
                _enderecoClienteMapeamento.Atualizar(entidadeEndereco);
                _pagamentosRepositorio.Atualizar(entidadePagamento);
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
