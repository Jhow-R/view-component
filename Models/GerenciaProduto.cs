using System.Collections.Generic;
using System.Linq;

namespace view_component.Models
{
    public class GerenciaProduto
    {
        public IEnumerable<Produto> GetTodosProdutos { get => produtos; }

        public List<Produto> GetProdutosPorTipo(string Tipo) => produtos
            .Where(p => p.Tipo.ToLower().Equals(Tipo.ToLower()))
            .ToList();

        private readonly List<Produto> produtos = new List<Produto>()
        {
            new Produto
            {
                Id = 1, Nome = "Suco de Laranja", Tipo = "Suco"
            },
            new Produto
            {
                Id = 2, Nome = "Guaraná", Tipo = "Refrigerante"
            },
            new Produto
            {
                Id = 3, Nome = "Melancia", Tipo = "Fruta"
            },
            new Produto
            {
                Id = 4, Nome = "Suco de Uva", Tipo = "Suco"
            },
            new Produto
            {
                Id = 5, Nome = "Abacaxi", Tipo = "Fruta"
            },
            new Produto
            {
                Id = 6, Nome = "Suco de Goiaba", Tipo = "Suco"
            },
            new Produto
            {
                Id = 7, Nome = "Pimenta do Reino", Tipo = "Condimento"
            },
            new Produto
            {
                Id = 8, Nome = "Uva", Tipo = "Fruta"
            },
            new Produto
            {
                Id = 9, Nome = "Suco de Abacaxi", Tipo = "Suco"
            },
            new Produto
            {
                Id = 10, Nome = "Gengibre", Tipo = "Condimento"
            },
        };
    }
}
