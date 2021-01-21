using System.Linq;
using System.Threading.Tasks;

namespace view_component.Models
{
    public class ProdutoDestaque
    {
        private readonly GerenciaProduto gp = new GerenciaProduto();
        public async Task<int> GetContaProduto()
        {
            return await Task.FromResult(gp.GetTodosProdutos.Count());
        }
        public async Task<int> GetContaProdutoPorTipo(string tipo)
        {
            return await Task.FromResult(gp.GetProdutosPorTipo(tipo).Count);
        }
    }
}
