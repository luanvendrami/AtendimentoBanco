﻿using Dominio.Entidades;
using Dominio.Interfaces.Repositorio.BaseRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorio
{
    public interface ICompraRepositorio : IBaseRepositorio<EfetuarCompra>
    {
        EfetuarCompra RetornaCompraId(int id);
        List<EfetuarCompra> ListaCompraPorCliente(int id);
    }
}
