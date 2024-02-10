using Adaptadores.Constantes;
using Adaptadores.Context;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Adaptadores.Mapping
{
    internal class ItenMap : IEntityTypeConfiguration<Iten>
    {
        public void Configure(EntityTypeBuilder<Iten> builder)
        {
            builder.ToTable(nameof(SiegContext.Itens), SchemeConstantes.SIEG);

            builder.HasKey(e => e.IdItem);

            builder.Property(e => e.IdItem)
                .HasColumnName("id_item");

            builder.Property(e => e.IdVenda)
                .HasColumnName("id_venda");

            builder.Property(e => e.IdProduto)
                .HasColumnName("id_produto");

            builder.Property(e => e.Preco)
                .HasColumnName("preco")
                .HasColumnType("decimal(10, 2)");

            builder.Property(e => e.Qtde)
                .HasColumnName("qtde");

            builder.Property(e => e.Subtotal)
                .HasColumnName("subtotal")
                .HasColumnType("decimal(10, 2)");
        }
    }
}
