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
    public class EnderecoClienteMapeamento : IEntityTypeConfiguration<EnderecoDoCliente>
    {
        public void Configure(EntityTypeBuilder<EnderecoDoCliente> builder)
        {
            builder.HasKey(p => p.Id);

            builder.ToTable("EnderecoCliente");

            builder.Property(p => p.Uf)
                .HasColumnType("varchar(2)");

            builder.Property(p => p.Cidade)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Bairro)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Rua)
                .HasColumnType("varchar(100)");

            builder.Property(p => p.NumeroResidencia)
                .HasColumnType("varchar(10)");

            builder.Property(p => p.Complemento)
                .HasColumnType("varchar(50)");
        }
    }
}
