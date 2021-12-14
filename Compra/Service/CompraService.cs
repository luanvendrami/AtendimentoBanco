using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Service;
using Dominio.Modelos;
using Dominio.Entidades;
using System.Collections.Generic;

namespace Compra.Service
{
    public class CompraService : ICompraService
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        private readonly ICompraRepositorio _compraRepositorio;

        public CompraService(IClienteRepositorio clienteRepositorio, ICompraRepositorio compraRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
            _compraRepositorio = compraRepositorio;
        }

        public string EfetuarCompra(EfetuarCompraDto dto)
        {
            var consultaCliente = _clienteRepositorio.ConsultarPorCpf(dto.Cpf);
            var entidadeCompra = new EfetuarCompra(consultaCliente.Id,dto.Parcelamento, dto.ValorCompra);
            _compraRepositorio.Adicionar(entidadeCompra);
            return $"Cliente cadastrado com sucesso!";
        }

    }
}
