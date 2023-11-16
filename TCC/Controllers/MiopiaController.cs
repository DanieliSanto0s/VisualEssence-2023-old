using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.JavaScript;
using Tcc.Context;
using Newtonsoft.Json.Linq;
using Tcc.Models;
using System.Security.Claims;
using System.Globalization;
using Microsoft.JSInterop.Implementation;

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
        public ActionResult CadastroMiopia()
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult Fase8()
        {
            return View();
        }

        public ActionResult GoodResult()
        {
            return View();
        }

        public ActionResult BadResult()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Fase8(Jogada jogada, int acertos)
        {
            int pontuacaoInt = acertos;

            int lastIdCrianca = Convert.ToInt32(TempData["LastIdCrianca"]);

            if (lastIdCrianca != 0)
            {
                var jogadaEnv = _context.Jogada.SingleOrDefault(j => j.IdCrianca == lastIdCrianca);

                jogadaEnv.PontuacaoJogo = pontuacaoInt;
                _context.SaveChangesAsync();
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EnviarDados(Jogada jogada, Crianca crianca, string NomeCrianca, int Idade, string dataString)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var novaCrianca = new Crianca()
            {
                IdUsuario = Convert.ToInt32(userId),
                Idade = Idade,
                NomeCrianca = NomeCrianca,
            };

            _context.Add(novaCrianca);
            await _context.SaveChangesAsync();

            int lastIdCrianca = novaCrianca.Id;

            //------------

            var novaJogada = new Jogada()
            {
                IdJogo = 1,
                IdCrianca = lastIdCrianca,
                PontuacaoJogo = 0,
                DataJogou = DateTime.Today
            };

            _context.Jogada.Add(novaJogada);
            await _context.SaveChangesAsync();

            int lastIdPartida = novaJogada.Id;
            
            TempData["LastIdCrianca"] = lastIdCrianca;

            return RedirectToAction("MiopiaGame", "Miopia");
        }


        public IActionResult MiopiaGame()
        {
            return View();
        }


    }


  

}