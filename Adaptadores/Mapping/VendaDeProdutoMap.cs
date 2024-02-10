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
    internal class VendaDeProdutoMap : IEntityTypeConfiguration<VendaDeProduto>
    {
        public void Configure(EntityTypeBuilder<VendaDeProduto> builder)
        {
            builder.ToTable(nameof(SiegContext.VendaDeProdutos), SchemeConstantes.SIEG);

            builder.HasKey(e => e.IdVenda);

            builder.Property(e => e.IdVenda)
                .HasColumnName("id_venda");

            builder.Property(e => e.IdCliente)
                .HasColumnName("id_cliente");

            builder.Property(e => e.DataVenda)
                .HasColumnName("data_venda")
                .HasColumnType("date");

            builder.Property(e => e.HoraVenda)
                .HasColumnName("hora_venda");

            builder.Property(e => e.TotalVenda)
                .HasColumnName("total_venda")
                .HasColumnType("decimal(10, 2)");
        }
    }
}
