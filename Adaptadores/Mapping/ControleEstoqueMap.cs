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
    internal class ControleEstoqueMap : IEntityTypeConfiguration<ControleEstoque>
    {       
        public void Configure(EntityTypeBuilder<ControleEstoque> builder)
        {
            builder.ToTable(nameof(SiegContext.ControleEstoques), SchemeConstantes.SIEG);

            builder.HasKey(s => s.Id);     

            builder.Property(e => e.Column1)
                .HasColumnName("column1")
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
