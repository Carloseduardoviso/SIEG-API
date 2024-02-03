using Adaptadores.Context;
using prmToolkit.NotificationPattern;

namespace Historias.Produto.Criar
{
    public class CriarProduto : Notifiable
    {
        private readonly SiegContext contexto;

        public CriarProduto(SiegContext contexto)
        {
            this.contexto = contexto;
        }

        public async Task<int> Executar(CriarProdutoDto criarProduto)
        {
            try
            {
                var produto = new Dominio.Entidades.Produto(criarProduto.Nome, criarProduto.EstoqueInicial, criarProduto.EstoqueMinimo, criarProduto.EstoqueAtual, criarProduto.Preco);

                await contexto.AddAsync(produto);
                await contexto.SaveChangesAsync();

                return produto.Id;
            }
            catch (Exception ex)
            {
                AddNotification("exception", $"{ex.Message} {ex.InnerException?.Message}");
                return default!;
            }
        }
    }
}
