using Adaptadores.Constantes;
using Adaptadores.Context;
using Dominio.Entidades;
using Dominio.Enumeracoes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptadores.Mapping
{
    internal class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable(nameof(SiegContext.Clientes), SchemeConstantes.SIEG);

            builder.HasKey(e => e.IdCliente);

            builder.Property(e => e.IdCliente)
               .HasColumnName("id_cliente");

            builder.Property(e => e.NomeDoCliente)
                .HasColumnName("cliente")
                .HasMaxLength(200);

            builder.Property(e => e.Endereco)
                .HasColumnName("endereco")
                .HasMaxLength(150);

            builder.Property(e => e.Bairro)
                .HasColumnName("bairro")
                .HasMaxLength(100);

            builder.Property(e => e.Cidade)
                .HasColumnName("cidade")
                .HasMaxLength(100);

            builder.Property(e => e.Uf)
                .HasColumnName("uf")
                .HasMaxLength(2);

            builder.Property(e => e.Cep)
                .HasColumnName("cep")
                .HasMaxLength(20);

            builder.Property(e => e.Email)
                .HasColumnName("email")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(e => e.Celular)
                .HasColumnName("celular")
                .HasMaxLength(20);

            builder.Property(e => e.StatusDoCliente)
                .HasColumnName("ativo_cliente")
                .HasMaxLength(1)
                .IsRequired()
                .HasConversion(
                    v => v.ToString(),
                    v => (StatusDoCliente)Enum.Parse(typeof(StatusDoCliente), v));
        }
    }
}
