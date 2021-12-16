using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Contexto
{
    public class ContextoSQL : DbContext
    {
        public ContextoSQL(DbContextOptions<ContextoSQL> options)
            : base(options)
        {}
    }
}
