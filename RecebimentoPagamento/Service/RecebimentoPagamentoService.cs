using Dominio.Entidades;
using Dominio.Enums;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Service;
using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecebimentoPagamento.Service
{
    public class RecebimentoPagamentoService : IRecebimentoPagamentoService
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        private readonly IPagamentoRepositorio _pagamentoRepositorio;

        public RecebimentoPagamentoService(IClienteRepositorio clienteRepositorio, IPagamentoRepositorio pagamentoRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
            _pagamentoRepositorio = pagamentoRepositorio;
        }

        public Cliente CosultarNomeClienteDebito(RecimentoPagamentoDto dto)
        {
            var consultaCliente = _clienteRepositorio.ConsultaPorNome(dto.NomeCompleto, dto.Cpf, dto.Rg);
            return consultaCliente;
        }

        public string Compra(RecimentoPagamentoDto dto)
        {
            var buscaClienteDb = _clienteRepositorio.ValidaBancoCliente(dto.Cpf, dto.Rg);
            if (buscaClienteDb != null && dto.EfetuarCompra != false)
            {
                var pagamentoEntidade = new Pagamento(buscaClienteDb.Id);
                if (buscaClienteDb.Id == pagamentoEntidade.IdCliente)
                {
                    _pagamentoRepositorio.Atualizar(pagamentoEntidade);
                    return $"Compra feita com sucesso!";
                }
                return $"A compra não foi efetuada!";
            }
            return $"Cliente não encontrado para efetuar a compra!";
        }

        public string Pagamento(RecimentoPagamentoDto dto)
        {
            var buscaClienteDb = _clienteRepositorio.ValidaBancoCliente(dto.Cpf, dto.Rg);
            if(buscaClienteDb != null)
            {
                var pagamentoEntidade = new Pagamento(buscaClienteDb.Id, dto.ValorPago, (TipoPagamento)buscaClienteDb.Pagamentos.FormaPagamento, (DateTime)buscaClienteDb.Pagamentos.DataVencimento);
                if (buscaClienteDb.Id == pagamentoEntidade.IdCliente)
                {
                    _pagamentoRepositorio.Adicionar(pagamentoEntidade);
                    return $"Adicionado com sucesso!";
                }
                return $"O pagamento não foi adicionado ao cliente!";
            }
            return $"O cliente não esta cadastrado!";
        }
    }
}
