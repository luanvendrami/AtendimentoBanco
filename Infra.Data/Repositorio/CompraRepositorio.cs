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
    public class CompraRepositorio : BaseRepositorio<Compra>, ICompraRepositorio
    {
        public CompraRepositorio(ContextoSQL context) : base(context)
        {
        }

        public Compra RetornaCompraId(int id)
        {
            return _context.Compra.AsNoTracking().FirstOrDefault(n => n.Id == id);
        }

    }
}
