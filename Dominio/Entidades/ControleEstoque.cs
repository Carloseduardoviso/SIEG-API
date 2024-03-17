using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("controle_estoque")]
    public partial class ControleEstoque
    {
        public int Id { get; set; }
        [Required]
        [Column("column1")]
        [StringLength(200)]
        public string? Column1 { get; set; }
    }
}
