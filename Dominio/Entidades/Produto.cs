using Dominio.Entidades.Base;
using Dominio.Enumeracoes;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    public class Produto : Entidade
    {
        protected Produto() { } 

        public Produto(string? nome, int estoqueInicial, int estoqueMinimo, int estoqueAtual, decimal? preco)
        {
            Nome = nome;
            EstoqueInicial = estoqueInicial;
            EstoqueMinimo = estoqueMinimo;
            EstoqueMinimo = estoqueAtual;
            Preco = preco;
            Status = StatusDoProduto.Ativo;
        }

        [Column("id_produto")]
        public int IdProduto { get; set; }
        public string? Nome { get; set; }
        public int EstoqueInicial { get; set; }
        public int EstoqueMinimo { get; set; }
        public int EstoqueAtual { get; set; }
        public decimal? Preco {  get; set; }
        public StatusDoProduto Status { get; set; }

        public void Inativar()
        {
            Status = StatusDoProduto.Inativa;
        }
    }
}
