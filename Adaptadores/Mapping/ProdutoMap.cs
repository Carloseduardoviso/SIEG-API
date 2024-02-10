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
    internal class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable(nameof(SiegContext.Produtos), SchemeConstantes.SIEG);

            builder.HasKey(e => e.IdProduto);

            builder.Property(e => e.IdProduto)
                .HasColumnName("id_produto");

            builder.Property(e => e.Nome)
                .HasColumnName("nome");

            builder.Property(e => e.EstoqueInicial)
                .HasColumnName("estoque_inicial");

            builder.Property(e => e.EstoqueMinimo)
                .HasColumnName("estoque_minimo");

            builder.Property(e => e.EstoqueAtual)
                .HasColumnName("estoque_atual");

            builder.Property(e => e.Preco)
                .HasColumnName("preco");

            builder.Property(e => e.Status)
                .HasColumnName("status");
        }
    }
}
