using Dominio.Entidades;
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

        public RecebimentoPagamentoService(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public List<Cliente> CosultarNomeClienteDebito(RecimentoPagamentoDto dto)
        {
            var consultaCliente = _clienteRepositorio.ConsultaPorNomeLista(dto.NomeCompleto, dto.Cpf, dto.Rg);
            return consultaCliente;
        }
    }
}
