using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dominio.Entidades
{
    [Table("itens")]
    public partial class Iten
    {
        [Column("id_item")]
        public int IdItem { get; set; }
        [Column("id_venda")]
        public int IdVenda { get; set; }
        [Column("id_produto")]
        public int IdProduto { get; set; }
        [Column("preco", TypeName = "decimal(10, 2)")]
        public decimal Preco { get; set; }
        [Column("qtde")]
        public int Qtde { get; set; }
        [Column("subtotal", TypeName = "decimal(10, 2)")]
        public decimal Subtotal { get; set; }
    }
}
