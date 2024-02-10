using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Enumeracoes;
using Microsoft.EntityFrameworkCore;

namespace Dominio.Entidades
{
    [Table("fornecedo")]
    public partial class Fornecedo
    {
        [Column("id_fornecedo")]
        public int IdFornecedo { get; set; }
        [Column("fornecedo")]
        [StringLength(200)]
        [Unicode(false)]
        public string? NomeDoFornecedor { get; set; }
        [Column("endereco")]
        [StringLength(150)]
        [Unicode(false)]
        public string? Endereco { get; set; }
        [Column("bairro")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Bairro { get; set; }
        [Column("cidade")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Cidade { get; set; }
        [Column("uf")]
        [StringLength(2)]
        [Unicode(false)]
        public string? Uf { get; set; }
        [Column("cep")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Cep { get; set; }
        [Required]
        [Column("email")]
        [StringLength(200)]
        [Unicode(false)]
        public string? Email { get; set; }
        [Column("celular")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Celular { get; set; }
        [Column("ativo_fornecedo")]
        [StringLength(1)]
        [Unicode(false)]
        public StatusDoFornecedor StatusDoFornecedor { get; set; }
    }
}
