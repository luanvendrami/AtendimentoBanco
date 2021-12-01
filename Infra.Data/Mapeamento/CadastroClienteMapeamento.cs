using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Mapeamento
{
    public class CadastroClienteMapeamento : IEntityTypeConfiguration<DadosCliente>
    {
        public void Configure(EntityTypeBuilder<DadosCliente> builder)
        {
            builder.HasKey(p => p.Id);

            builder.ToTable("Cliente");

            builder.Property(p => p.NomeCompleto)
                .HasColumnType("varchar(70)");

            builder.Property(p => p.Cpf)
                .HasColumnType("varchar(11)");

            builder.Property(p => p.Rg)
                .HasColumnType("varchar(12)");

            builder.Property(p => p.DataNascimento)
                .HasColumnType("datetime");
        }
    }
}
