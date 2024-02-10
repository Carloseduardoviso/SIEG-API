using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dominio.Entidades
{
    [Table("movimentacao")]
    public partial class Movimentacao
    {
        [Column("id_movimentacao")]
        public int IdMovimentacao { get; set; }
        [Column("id_produto")]
        public int IdProduto { get; set; }
        [Column("id_entrada_saida")]
        public int IdEntradaSaida { get; set; }
        [Column("tipo_movimentacao")]
        public int TipoMovimentacao { get; set; }
        [Column("qtde")]
        public int Qtde { get; set; }
        [Column("motivo")]
        public int Motivo { get; set; }
        [Column("data_movimentacao")]
        public int DataMovimentacao { get; set; }
        [Column("hora_movimentacao")]
        public int HoraMovimentacao { get; set; }
    }
}
