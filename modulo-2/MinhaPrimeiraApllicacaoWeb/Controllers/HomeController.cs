using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraApllicacaoWeb.Models;
using MinhaPrimeiraApllicacaoWeb.DataContext;
using Microsoft.EntityFrameworkCore;

namespace MinhaPrimeiraApllicacaoWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ProdutoContext _context;

    public HomeController(ILogger<HomeController> logger, ProdutoContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    /*EntityFramework*/
    public async Task<IActionResult> Listar()
    {
        var produtos = await _context.Produtos.ToListAsync();
        return View(produtos);
    }
    public IActionResult Criar()
    {
        return View(new ProdutoModel());
    }
    public async Task<IActionResult> Editar(int id)
    {
        var produto = await _context.Produtos.FindAsync(id);
        if (produto == null)
        {
            return NotFound();
        }
        return View(produto);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Criar([Bind("Nome,Descricao,Preco,EstaAtivo,Id")] ProdutoModel produto)
    {
        if (ModelState.IsValid)
        {
            _context.Add(produto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Listar));
        }
        return View(produto);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Editar(int Id, [Bind("Nome,Descricao,Preco,EstaAtivo,Id")] ProdutoModel produto)
    {
        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(produto);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdutoExists(produto.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Listar));
        }
        return View(produto);
    }

    [HttpPost]
    public async Task<IActionResult> Deletar(int id)
    {
        var produto = await _context.Produtos.FindAsync(id);
        if (produto != null)
        {
            _context.Produtos.Remove(produto);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Listar));
    }
    private bool ProdutoExists(int id)
    {
        return (_context.Produtos?.Any(e => e.Id == id)).GetValueOrDefault();
    }

}
