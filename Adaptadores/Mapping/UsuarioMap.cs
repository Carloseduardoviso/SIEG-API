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
    internal class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable(nameof(SiegContext.Usuarios), SchemeConstantes.SIEG);

            builder.HasKey(e => e.IdUsuario);

            builder.Property(e => e.IdUsuario)
                .HasColumnName("id_usuario");

            builder.Property(e => e.Login)
                .HasColumnName("login")
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(e => e.Senha)
                .HasColumnName("senha")
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(e => e.AtivoUsuario)
                .HasColumnName("ativo_usuario")
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsRequired();
        }
    }
}
