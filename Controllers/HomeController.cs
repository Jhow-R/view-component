using Microsoft.AspNetCore.Mvc;
using view_component.Models;

namespace view_component.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            GerenciaProduto gp = new GerenciaProduto();
            var produtos = gp.GetTodosProdutos;
            
            return View(produtos);
        }
    }
}
