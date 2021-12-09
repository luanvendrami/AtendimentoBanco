﻿using Dominio.Entidades;
using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Service
{
    public interface IRecebimentoPagamentoService
    {
        List<Cliente> CosultarNomeClienteDebito(RecimentoPagamentoDto dto);
    }
}