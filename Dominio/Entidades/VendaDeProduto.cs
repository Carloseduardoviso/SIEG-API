using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dominio.Entidades
{
    [Table("venda")]
    public partial class VendaDeProduto
    {
        [Column("id_venda")]
        public int IdVenda { get; set; }
        [Column("id_cliente")]
        public int IdCliente { get; set; }
        [Column("data_venda", TypeName = "date")]
        public DateTime DataVenda { get; set; }
        [Column("hora_venda")]
        public TimeSpan HoraVenda { get; set; }
        [Column("total_venda", TypeName = "decimal(10, 2)")]
        public decimal TotalVenda { get; set; }
    }
}
