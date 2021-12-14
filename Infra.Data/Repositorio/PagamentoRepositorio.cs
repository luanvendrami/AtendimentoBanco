using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Infra.Data.Contexto;
using Infra.Data.Repositorio.BaseRepositorio;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infra.Data.Repositorio
{
    public class PagamentoRepositorio : BaseRepositorio<Pagamento>, IPagamentoRepositorio
    {
        public PagamentoRepositorio(ContextoSQL context) : base(context)
        {
        }
        public Pagamento RetornaPagamentoId(int id)
        {
            return _context.Pagamento.AsNoTracking().FirstOrDefault(n => n.Id == id);
        }

        public Pagamento BuscarPorCpf(string cpf)
        {
            return _context.Pagamento.AsNoTracking()
                .Include(x => x.PagamentoNavegation)
                .FirstOrDefault(x => x.PagamentoNavegation.Cpf == cpf);
        }
    }
}
