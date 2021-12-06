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
                .HasColumnType("varchar(70)")
                .IsRequired();

            builder.Property(p => p.Cpf)
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder.Property(p => p.Rg)
                .HasColumnType("varchar(12)")
                .IsRequired(); ;

            builder.Property(p => p.DataNascimento)
                .HasColumnType("datetime")
                .IsRequired(); ;

            builder.HasOne(x => x.Endereco).WithOne(x => x.EnderecoNavegation).HasForeignKey<EnderecoDoCliente>(x => x.IdCliente);
            builder.HasOne(x => x.Pagamentos).WithOne(x => x.PagamentoNavegation).HasForeignKey<PagamentosCliente>(x => x.IdCliente);
        }
    }
}
