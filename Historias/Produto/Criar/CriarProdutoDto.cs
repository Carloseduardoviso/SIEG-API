using Dominio.Enumeracoes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historias.Produto.Criar
{
    public class CriarProdutoDto
    {
        [Required(ErrorMessage = "O nome é obrigatório!")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O estoque inicial é obrigatório!")]
        public int EstoqueInicial { get; set; }

        [Required(ErrorMessage = "O estoque minimo é obrigatório!")]
        public int EstoqueMinimo { get; set; }

        [Required(ErrorMessage = "O estoque atual é obrigatório!")]
        public int EstoqueAtual { get; set; }

        [Required(ErrorMessage = "O preço é obrigatório!")]
        public decimal? Preco { get; set; }

        [Required(ErrorMessage = "Informar se o produto esta ativo!")]
        public StatusDoProduto Status {  get; set; }
    }
}
