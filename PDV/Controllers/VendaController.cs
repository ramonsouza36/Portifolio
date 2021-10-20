using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dados;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using PDV.Models;

namespace PDV.Controllers
{
    public class VendaController : Controller
    {
        
        private readonly ApplicationDbContext _context;

        public VendaController(ApplicationDbContext context)
        {
           _context = context;
        }

        public IActionResult Venda()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Venda(Venda venda){
            venda.dataVenda = DateTime.Now;
            _context.Add(venda);
            await _context.SaveChangesAsync();
            return Redirect("https://localhost:5001/Venda/Venda");
        }

        [HttpPost]
        public async Task<IActionResult> ItensVenda(ItensVendas itemvenda){
            
            var Codigo = _context.Vendas.Max( v => v.Id);
            Codigo = Codigo +1;
            itemvenda.CodigoVenda = Codigo;
            _context.ItensVendas.Add(itemvenda);
            await _context.SaveChangesAsync();
            return Redirect("https://localhost:5001/Venda/Venda");
        }

        public int Codigo()
        {
            var Codigo = _context.Vendas.Max( v => v.Id);
            Codigo = Codigo +1;
            return Codigo;
        }

        [HttpGet]
        public IActionResult Buscar(int id)
        {
            var Codigo = _context.Vendas.Max( v => v.Id);
            Codigo = Codigo +1;
            var itens = _context.ItensVendas.Where( i => i.CodigoVenda == Codigo);
            return View(itens.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
