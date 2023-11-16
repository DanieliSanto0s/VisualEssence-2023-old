using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Tcc.Context;
using Tcc.Models;

namespace Tcc.Controllers
{
    public class DaltonismoController : Controller
    {
        private readonly BancoDados _context;

        public DaltonismoController(BancoDados context)
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

        public ActionResult Fase8()
        {
            return View();
        }

        public ActionResult Fase9()
        {
            return View();
        }

        public ActionResult Fase10()
        {
            return View();
        }

        public ActionResult Fase11()
        {
            return View();
        }

        public ActionResult Fase12()
        {
            return View();
        }

        public ActionResult Fase13()
        {
            return View();
        }

        public ActionResult Fase14()
        {
            return View();
        }

        public ActionResult Fase15()
        {
            return View();
        }

        public ActionResult Fase16()
        {
            return View();
        }

        public ActionResult Fase17()
        {
            return View();

        }
        public ActionResult Fase18()
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
        [HttpGet]

        public ActionResult CadastroDaltonismo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Fase18(Jogada jogada, int acertos)
        {
            int pontuacaoInt = acertos;

            int lastIdCrianca = Convert.ToInt32(TempData["LastIdCrianca2"]);

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
                IdJogo = 2,
                IdCrianca = lastIdCrianca,
                PontuacaoJogo = 0,
                DataJogou = DateTime.Today
            };

            _context.Jogada.Add(novaJogada);
            await _context.SaveChangesAsync();

            int lastIdPartida = novaJogada.Id;

            TempData["LastIdCrianca2"] = lastIdCrianca;

            return RedirectToAction("DaltoGame", "Daltonismo");
        }

        public IActionResult DaltoGame()
        {
            return View();
        }


    }
}
