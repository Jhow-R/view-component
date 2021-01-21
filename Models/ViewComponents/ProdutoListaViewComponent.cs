using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace view_component.Models.ViewComponents
{
    [ViewComponent]
    public class ProdutoListaViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string tipo)
        {
            var produtos = await GetProdutosAsync(tipo);
            return View(produtos);
        }

        private Task<IEnumerable<Produto>> GetProdutosAsync(string tipo)
        {
            return Task.FromResult(GetProdutos(tipo));
        }

        private IEnumerable<Produto> GetProdutos(string tipo)
        {
            GerenciaProduto gp = new GerenciaProduto();
            return gp.GetProdutosPorTipo(tipo);
        }
    }
}
