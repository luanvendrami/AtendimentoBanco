using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Contexto
{
    public class ContextoSQL : DbContext
    {
        public ContextoSQL(DbContextOptions<ContextoSQL> options)
            : base(options)
        {}
        public DbSet<DadosCliente> InformacaoCliente { get; set; }
        public DbSet<EnderecoCliente> EnderecoCliente { get; set; }
    }
}
