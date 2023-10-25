using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tcc.Context;
using Tcc.Models;

namespace Tcc.Controllers
{
    public class MiopiaController : Controller
    {
    private readonly BancoDados _context;

        public MiopiaController(BancoDados context)
        {
            _context = context;
        }
        public IActionResult Fase1()
        {
            return View();
        }

        public IActionResult Fase2()
        {
            return View();
        }

        public IActionResult Fase3()
        {
            return View();
        }

        public IActionResult Fase4()
        {
            return View();
        }

        public IActionResult Fase5()
        {
            return View();
        }

        public IActionResult Fase6()
        {
            return View();
        }

        public IActionResult Fase7()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Fase8()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Fase8([FromBody] Jogada novaJogada)
        {
            int idCrianca = HttpContext.Session.GetInt32("IdCrianca");
            var jogada = new Jogada()
            {
                  PontuacaoJogo = novaJogada.PontuacaoJogo,
                  IdJogo = novaJogada.IdJogo,
                  DataJogou = DateTime.Now,
                  
            };

            _context.Jogada.Add(novaJogada);
            _context.SaveChanges();


            return View();
        }

    }
}
