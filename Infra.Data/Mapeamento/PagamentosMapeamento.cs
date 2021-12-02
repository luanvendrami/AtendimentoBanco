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

            builder.ToTable("Pagamentos");

            builder.Property(p => p.FormaPagamento)
                .HasColumnType("tinyint");

            builder.Property(p => p.ConfirmadoPagamento)
                .HasColumnType("bit");

            builder.Property(p => p.ValorPagamentoAgendado)
                .HasColumnType("decimal");

            builder.Property(p => p.DataPagamentoAgendado)
                .HasColumnType("datetime");

            builder.Property(p => p.ValorPagamento)
               .HasColumnType("decimal");

            builder.Property(p => p.DataPagamento)
               .HasColumnType("datetime");

            builder.Property(p => p.ValorMulta)
               .HasColumnType("decimal");

            builder.Property(p => p.ValorDesconto)
               .HasColumnType("decimal");
        }
    }
}
