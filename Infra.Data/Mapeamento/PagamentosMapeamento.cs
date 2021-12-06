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
    public class PagamentosMapeamento : IEntityTypeConfiguration<PagamentosCliente>
    {
        public void Configure(EntityTypeBuilder<PagamentosCliente> builder)
        {
            builder.HasKey(p => p.Id);

            builder.ToTable("Pagamento");

            builder.Property(p => p.FormaPagamento)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.ConfirmadoPagamento)
                .HasColumnType("bit")
                .IsRequired();

            builder.Property(p => p.ValorPagamentoAgendado)
                .HasColumnType("decimal")
                .IsRequired();

            builder.Property(p => p.DataPagamentoAgendado)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(p => p.ValorPagamento)
               .HasColumnType("decimal")
               .IsRequired();

            builder.Property(p => p.DataPagamento)
               .HasColumnType("datetime")
               .IsRequired();

            builder.Property(p => p.ValorMulta)
               .HasColumnType("decimal")
               .IsRequired();

            builder.Property(p => p.ValorDesconto)
               .HasColumnType("decimal")
               .IsRequired();

            builder.Property(p => p.IdCliente)
               .HasColumnType("int")
               .IsRequired();

            builder.HasOne(x => x.PagamentoNavegation).WithMany().HasForeignKey(x => x.IdCliente);
        }
    }
}
