using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Infra.Data.Contexto;
using Infra.Data.Repositorio.BaseRepositorio;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infra.Data.Repositorio
{
    public class PagamentosRepositorio : BaseRepositorio<PagamentosCliente>, IPagamentosRepositorio
    {
        public PagamentosRepositorio(ContextoSQL context) : base(context)
        {
        }
        public PagamentosCliente RetornaClientId(int id)
        {
            return _context.Pagamentos.AsNoTracking().FirstOrDefault(n => n.Id == id);
        }
    }
}
