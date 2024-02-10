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
    internal class MovimentacaoMap : IEntityTypeConfiguration<Movimentacao>
    {
        public void Configure(EntityTypeBuilder<Movimentacao> builder)
        {
            builder.ToTable(nameof(SiegContext.Movimentacoes), SchemeConstantes.SIEG);

            builder.HasKey(e => e.IdMovimentacao);

            builder.Property(e => e.IdMovimentacao)
                .HasColumnName("id_movimentacao");

            builder.Property(e => e.IdProduto)
                .HasColumnName("id_produto");

            builder.Property(e => e.IdEntradaSaida)
                .HasColumnName("id_entrada_saida");

            builder.Property(e => e.TipoMovimentacao)
                .HasColumnName("tipo_movimentacao");

            builder.Property(e => e.Qtde)
                .HasColumnName("qtde");

            builder.Property(e => e.Motivo)
                .HasColumnName("motivo");

            builder.Property(e => e.DataMovimentacao)
                .HasColumnName("data_movimentacao");

            builder.Property(e => e.HoraMovimentacao)
                .HasColumnName("hora_movimentacao");
        }
    }
}
