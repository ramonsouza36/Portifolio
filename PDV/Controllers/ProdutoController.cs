using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dados;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using PDV.Models;

namespace PDV.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProdutoController(ApplicationDbContext context)
        {
           _context = context;
        }

        [HttpGet]
        public IActionResult Produto()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Produto(Produto produtos)
        {
            if(produtos.Id ==0){
            _context.Produtos.Add(produtos);
            }
            else {
                var produto = _context.Produtos.First(p => p.Id == produtos.Id);
                produto.Nome = produtos.Nome;
                produto.Quantidade = produtos.Quantidade;
                produto.ValorUnitario = produtos.ValorUnitario;
            }
            await _context.SaveChangesAsync();
            return Redirect("https://localhost:5001/Estoque/Estoque");
             
        }

        public IActionResult Editar(int id)
        {
            var produto = _context.Produtos.First(p => p.Id == id);
            return View("Produto",produto);
        }

        public async Task<IActionResult> Excluir(int id)
        {
            var produto = _context.Produtos.First(p => p.Id == id);
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();

            return Redirect("https://localhost:5001/Estoque/Estoque");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
