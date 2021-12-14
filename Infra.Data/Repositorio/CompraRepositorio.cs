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
    public class CompraRepositorio : BaseRepositorio<EfetuarCompra>, ICompraRepositorio
    {
        public CompraRepositorio(ContextoSQL context) : base(context)
        {
        }

        public EfetuarCompra RetornaCompraId(int id)
        {
            return _context.Compra.AsNoTracking().FirstOrDefault(n => n.Id == id);
        }

        public List<EfetuarCompra> ListaCompraPorCliente(int id)
        {
            return _context.Compra.AsNoTracking().Where(x => x.IdCliente == id).ToList();
        }

    }
}
