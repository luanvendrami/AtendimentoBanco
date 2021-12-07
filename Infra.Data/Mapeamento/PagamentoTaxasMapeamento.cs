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
    public class PagamentoTaxasMapeamento : IEntityTypeConfiguration<PagamentoTaxas>
    {
        public void Configure(EntityTypeBuilder<PagamentoTaxas> builder)
        {
            builder.HasKey(p => p.Id);

            builder.ToTable("PagamentoTaxas");

            builder.Property(p => p.Juros)
                .HasColumnType("decimal")
                .IsRequired();

            builder.Property(p => p.Desconto)
                .HasColumnType("decimal")
                .IsRequired();

            builder.Property(p => p.IdPagamento)
                .HasColumnType("int")
                .IsRequired();
        }
    }
}
