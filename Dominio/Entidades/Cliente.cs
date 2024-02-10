using Dominio.Entidades.Base;
using Dominio.Enumeracoes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("cliente")]
    public class Cliente : Entidade
    {
        [Column("id_cliente")]
        public int IdCliente { get; set; }
        [Column("cliente")]
        [StringLength(200)]
        public string? NomeDoCliente { get; set; }
        [Column("endereco")]
        [StringLength(150)]
        public string? Endereco { get; set; }
        [Column("bairro")]
        [StringLength(100)]
        public string? Bairro { get; set; }
        [Column("cidade")]
        [StringLength(100)]
        public string? Cidade { get; set; }
        [Column("uf")]
        [StringLength(2)]
        public string? Uf { get; set; }
        [Column("cep")]
        [StringLength(20)]
        public string? Cep { get; set; }
        [Required]
        [Column("email")]
        [StringLength(200)]
        public string? Email { get; set; }
        [Column("celular")]
        [StringLength(20)]
        public string? Celular { get; set; }
        [Column("ativo_cliente")]
        [StringLength(1)]
        public StatusDoCliente StatusDoCliente { get; set; }
    }
}
