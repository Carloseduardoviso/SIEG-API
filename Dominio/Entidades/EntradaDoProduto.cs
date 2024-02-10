using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dominio.Entidades
{
    [Table("entrada")]
    public partial class EntradaDoProduto
    {
        [Column("id_entrada")]
        public int IdEntrada { get; set; }
        [Column("id_produto")]
        public int IdProduto { get; set; }
        [Column("data_entrada", TypeName = "date")]
        public DateTime DataEntrada { get; set; }
        [Column("qtde_entrada")]
        public int QtdeEntrada { get; set; }
        [Required]
        [Column("motivo_entrada")]
        [StringLength(120)]
        [Unicode(false)]
        public string? MotivoEntrada { get; set; }
        [Column("hora_entrada")]
        public TimeSpan? HoraEntrada { get; set; }
    }
}
