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
    public class PagamentoMapeamento : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.ToTable("Pagamento");

            builder.Property(p => p.FormaPagamento)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.ValorPago)
                .HasColumnType("decimal");

            builder.Property(p => p.DataVencimento)
                .HasColumnType("datetime");

            builder.Property(p => p.ValorPagamentoComReajustes)
               .HasColumnType("decimal");

            builder.Property(p => p.DataPagamento)
               .HasColumnType("datetime");

            builder.Property(p => p.Juros)
               .HasColumnType("decimal");

            builder.Property(p => p.Desconto)
               .HasColumnType("decimal");

            builder.Property(p => p.IdCliente)
               .HasColumnType("int")
               .IsRequired();

            builder.HasOne(x => x.PagamentoNavegation).WithMany().HasForeignKey(x => x.IdCliente);
        }
    }
}
