using Adaptadores.Constantes;
using Adaptadores.Context;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Adaptadores.Mapping
{
    internal class EntradaDoProdutoMap : IEntityTypeConfiguration<EntradaDoProduto>
    {
        public void Configure(EntityTypeBuilder<EntradaDoProduto> builder)
        {
            builder.ToTable(nameof(SiegContext.EntradaDoProdutos), SchemeConstantes.SIEG);

            builder.HasKey(s => s.IdEntrada);

            builder.Property(s => s.IdEntrada)
                .HasColumnName("id_entrada");

            builder.Property(e => e.IdProduto)
                .HasColumnName("id_produto");

            builder.Property(e => e.DataEntrada)
                .HasColumnName("data_entrada")
                .HasColumnType("date");

            builder.Property(e => e.QtdeEntrada)
                .HasColumnName("qtde_entrada");

            builder.Property(e => e.MotivoEntrada)
                .HasColumnName("motivo_entrada")
                .HasMaxLength(120)
                .IsRequired()
                .IsUnicode(false);

            builder.Property(e => e.HoraEntrada)
                .HasColumnName("hora_entrada");
        }
    }
}
