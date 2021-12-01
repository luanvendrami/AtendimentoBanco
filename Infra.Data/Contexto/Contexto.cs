using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {}
    }
}
