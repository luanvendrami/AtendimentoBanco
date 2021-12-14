using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Contexto
{
    public class ContextoSQL : DbContext
    {
        public ContextoSQL(DbContextOptions<ContextoSQL> options)
            : base(options)
        {}

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Pagamento> Pagamento { get; set; }
        public DbSet<EfetuarCompra> Compra { get; set; }
    }
}
