using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Infra.Data.Contexto;
using Infra.Data.Repositorio.BaseRepositorio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositorio
{
    public class PagamentoTaxasRepositorio : BaseRepositorio<PagamentoTaxas>, IPagamentoTaxasRepositorio
    {
        public PagamentoTaxasRepositorio(ContextoSQL context) : base(context)
        {
        }
        public PagamentoTaxas RetornaPagamentoId(int id)
        {
            return _context.PagamentoTaxas.AsNoTracking().FirstOrDefault(n => n.Id == id);
        }
    }
}
