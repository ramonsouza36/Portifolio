using System.Diagnostics;
using System.Linq;
using Dados;
using Microsoft.AspNetCore.Mvc;
using PDV.Models;

namespace PDV.Controllers
{
    public class EstoqueController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EstoqueController(ApplicationDbContext context)
        {
           _context = context;
        }

        [HttpGet]
        public IActionResult Estoque()
        {
            var produtos = _context.Produtos.ToList();

            return View(produtos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
