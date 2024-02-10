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
    internal class SaidaDeProdutoMap : IEntityTypeConfiguration<SaidaDeProduto>
    {
        public void Configure(EntityTypeBuilder<SaidaDeProduto> builder)
        {
            builder.ToTable(nameof(SiegContext.SaidaDeProdutos), SchemeConstantes.SIEG);

            builder.HasKey(e => e.IdSaida);

            builder.Property(e => e.IdSaida)
                .HasColumnName("id_saida");

            builder.Property(e => e.IdProduto)
                .HasColumnName("id_produto");

            builder.Property(e => e.DataSaida)
                .HasColumnName("data_saida")
                .HasColumnType("date");

            builder.Property(e => e.QtdeSaida)
                .HasColumnName("qtde_saida");

            builder.Property(e => e.MotivoSaida)
                .HasColumnName("motivo_saida")
                .HasMaxLength(120)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(e => e.HoraSaida)
                .HasColumnName("hora_saida");
        }
    }
}
