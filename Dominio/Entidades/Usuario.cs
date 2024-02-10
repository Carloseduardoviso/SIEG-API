using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dominio.Entidades
{
    [Table("usuario")]
    public partial class Usuario
    {
        [Column("id_usuario")]
        public int IdUsuario { get; set; }
        [Required]
        [Column("login")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Login { get; set; }
        [Required]
        [Column("senha")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Senha { get; set; }
        [Required]
        [Column("ativo_usuario")]
        [StringLength(1)]
        [Unicode(false)]
        public string? AtivoUsuario { get; set; }
    }
}
