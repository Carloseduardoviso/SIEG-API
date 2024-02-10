using Adaptadores.Constantes;
using Adaptadores.Context;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptadores.Mapping
{
    internal class FornecedorMap : IEntityTypeConfiguration<Fornecedo>
    {
        public void Configure(EntityTypeBuilder<Fornecedo> builder)
        {
            builder.ToTable(nameof(SiegContext.Fornecedores), SchemeConstantes.SIEG);

            builder.HasKey(e => e.IdFornecedo);

            builder.Property(e => e.IdFornecedo)
                .HasColumnName("id_fornecedo");

            builder.Property(e => e.NomeDoFornecedor)
                .HasColumnName("fornecedo")
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Endereco)
                .HasColumnName("endereco")
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.Bairro)
                .HasColumnName("bairro")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Cidade)
                .HasColumnName("cidade")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Uf)
                .HasColumnName("uf")
                .HasMaxLength(2)
                .IsUnicode(false);

            builder.Property(e => e.Cep)
                .HasColumnName("cep")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Email)
                .HasColumnName("email")
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(e => e.Celular)
                .HasColumnName("celular")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.StatusDoFornecedor)
                .HasColumnName("ativo_fornecedo")
                .HasMaxLength(1)
                .IsUnicode(false);
        }
    }
}
