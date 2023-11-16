using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Tcc.Context;
using Tcc.Models;
using Tcc.ViewModel;

namespace Tcc.Controllers
{
    public class PerfilController : Controller
    {
        private readonly BancoDados _context;

        public PerfilController(BancoDados context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult Perfil()
        {
    
            int IdUsuario = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var usuario = _context.Usuario.FirstOrDefault(u => u.Id == IdUsuario);

            var informacoesUsuario = new Usuario
            {
                NomeResp = usuario.NomeResp,
                Email = usuario.Email
            };

            List<HistoricoJogada> historicoPartidas = null;

            if (_context.Jogada.Any(j => j.Crianca.IdUsuario == IdUsuario))
            {
                historicoPartidas = _context.Jogada
               .Where(j => j.Crianca.IdUsuario == IdUsuario)
               .Select(j => new HistoricoJogada
               {
                   IdJogada = j.Id,
                   IdCrianca = j.IdCrianca,
                   NomeCrianca = j.Crianca.NomeCrianca,
                   NomeJogo = j.IdJogo == 1 ? "Miopia" : j.IdJogo == 2 ? "Daltonismo" : (j.IdJogo.ToString()),
                   DataJogou = j.DataJogou.ToString("dd/MM/yyyy"),
                   PontuacaoJogo = j.PontuacaoJogo,
                   NomeResp = usuario.NomeResp,
                   Email = usuario.Email,


                   // Adicione outras propriedades conforme necessário
               })   
               .ToList();
            }

            var viewModel = new PerfilViewModel
            {
                HistoricoJogada = historicoPartidas,
                Usuario = informacoesUsuario
            };

            return View(viewModel);
        }
    }
}
