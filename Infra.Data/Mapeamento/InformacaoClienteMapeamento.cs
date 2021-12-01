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
    public class InformacaoClienteMapeamento : IEntityTypeConfiguration<InformacaoCliente>
    {
        public void Configure(EntityTypeBuilder<InformacaoCliente> builder)
        {
            builder.HasKey(p => p.Id);

            builder.ToTable("Cliente");

            builder.Property(p => p.NomeCompleto)
                .IsRequired()
                .HasColumnType("varchar(70)");

            builder.Property(p => p.Cpf)
                .IsRequired()
                .HasColumnType("varchar(11)");

            builder.Property(p => p.Rg)
                .IsRequired()
                .HasColumnType("varchar(12)");

            builder.Property(p => p.DataNascimento)
                .IsRequired()
                .HasColumnType("datetime");
        }
    }
}
