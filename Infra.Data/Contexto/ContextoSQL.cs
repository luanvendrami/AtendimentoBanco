using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Contexto
{
    public class ContextoSQL : DbContext
    {
        public ContextoSQL(DbContextOptions<ContextoSQL> options)
            : base(options)
        {}

        public DbSet<DadosCliente> Cliente { get; set; }
        public DbSet<EnderecoDoCliente> Endereco { get; set; }
        public DbSet<PagamentosCliente> Pagamento { get; set; }
    }
}
