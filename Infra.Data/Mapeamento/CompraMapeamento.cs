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
    public class CompraMapeamento : IEntityTypeConfiguration<EfetuarCompra>
    {
        public void Configure(EntityTypeBuilder<EfetuarCompra> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.ToTable("Compra");

            builder.Property(p => p.Parcelamento)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.ValorCompra)
                .HasColumnType("decimal")
                .IsRequired();

            builder.Property(p => p.DataCompra)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(p => p.VencimentoParcelas)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(p => p.JurosValorParcelado)
                .HasColumnType("decimal")
                .IsRequired();

            builder.Property(p => p.IdCliente)
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(x => x.CompraNavegation).WithMany().HasForeignKey(x => x.IdCliente);
        }
    }
}
