using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Service;
using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamentos.Service
{
    public class PagamentosService : IPagamentosService
    {
        private readonly IPagamentosRepositorio _pagamentosRepositorio;

        public PagamentosService(IPagamentosRepositorio pagamentosRepositorio)
        {
            _pagamentosRepositorio = pagamentosRepositorio;
        }

        public string CadastroPagamentos(PagamentoDto dto)
        {
            var pagamentosClientesEntidades = new PagamentosCliente(dto.FormaPagamento, dto.ConfirmadoPagamento, dto.ValorPagamentoAgendado, dto.DataPagamentoAgendado, dto.ValorPagamento, dto.DataPagamento, dto.ValorMulta, dto.ValorDesconto);
            if (pagamentosClientesEntidades.Validacao())
            {
                _pagamentosRepositorio.Adicionar(pagamentosClientesEntidades);
                return $"Pagamento cadastrado com sucesso!";
            }
            else
            {
                return $"Pagamento não foi cadastrado, verifique as informações!";
            }
        }

        public PagamentosCliente PagamentosPorId(int id)
        {
            var retorno = _pagamentosRepositorio.RetornaPagamentoId(id);
            return retorno;
        }

        public string AtualizarPagamento(int id, PagamentoDto dto)
        {
            var consultaRepositorio = _pagamentosRepositorio.RetornaPagamentoId(id);
            if (consultaRepositorio.Id == id)
            {
                var pagamentoCliente = new PagamentosCliente(consultaRepositorio.Id, dto.FormaPagamento, dto.ConfirmadoPagamento, dto.ValorPagamentoAgendado, dto.DataPagamentoAgendado, dto.ValorPagamento, dto.DataPagamento, dto.ValorMulta, dto.ValorDesconto);
                consultaRepositorio = pagamentoCliente;
                _pagamentosRepositorio.Atualizar(consultaRepositorio);
            }
            return $"Alterado com sucesso!";
        }

        public string DeletarPagamento(int id)
        {
            var consultaRepositorio = _pagamentosRepositorio.RetornaPagamentoId(id);
            _pagamentosRepositorio.Remover(consultaRepositorio.Id);
            return $"Deletado com sucesso!";
        }
    }
}
