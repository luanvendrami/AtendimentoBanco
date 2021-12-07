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
    public class EnderecoMapeamento : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(p => p.Id);

            builder.ToTable("Endereco");

            builder.Property(p => p.Uf)
                .HasColumnType("varchar(2)")
                .IsRequired();

            builder.Property(p => p.Cidade)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(p => p.Bairro)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(p => p.Rua)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.NumeroResidencia)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(p => p.Complemento)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(p => p.IdCliente)
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(x => x.EnderecoNavegation).WithOne().HasForeignKey<Endereco>(x => x.IdCliente);
               
        }
    }
}
