using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dominio.Entidades
{
    [Table("saida")]
    public partial class SaidaDeProduto
    {
        [Column("id_saida")]
        public int IdSaida { get; set; }
        [Column("id_produto")]
        public int IdProduto { get; set; }
        [Column("data_saida", TypeName = "date")]
        public DateTime DataSaida { get; set; }
        [Column("qtde_saida")]
        public int QtdeSaida { get; set; }
        [Required]
        [Column("motivo_saida")]
        [StringLength(120)]
        [Unicode(false)]
        public string? MotivoSaida { get; set; }
        [Column("hora_saida")]
        public TimeSpan? HoraSaida { get; set; }
    }
}
