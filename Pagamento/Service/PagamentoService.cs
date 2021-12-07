using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Service;
using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamento.Service
{
    public class PagamentoService : IPagamentoService
    {
        private readonly IPagamentoTaxasRepositorio _pagamentoTaxasRepositorio;

        public PagamentoService(IPagamentoTaxasRepositorio pagamentoTaxasRepositorio)
        {
            _pagamentoTaxasRepositorio = pagamentoTaxasRepositorio;
        }

        public string SalvaTaxas(EncargosDto dto)
        {
            var entidadePagamentoTaxas = new PagamentoTaxas(dto.Juros, dto.Desconto);
            if (entidadePagamentoTaxas.Validacao())
            {
                _pagamentoTaxasRepositorio.Adicionar(entidadePagamentoTaxas);
                return $"Taxa salva com sucesso!";
            }
            else
            {
                return $"Taxa não foi salva, verifique as informações!";
            }
        }
    }
}
