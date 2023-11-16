using System.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;
using System.Security.Claims;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using Tcc.Context;
using Tcc.Models;
using Microsoft.AspNetCore.Identity;
using Tcc.Segurança;
using System.Net.Mail;

namespace Tcc.Controllers
{

    public class ContaController : Controller
    {
        private readonly BancoDados _context;

        public ContaController(BancoDados context)
        {
            _context = context;
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastro(Usuario usuario)
        {
            if (_context.Usuario.Where(u => u.Email == usuario.Email).FirstOrDefault() == null)
            {
                usuario.Email = usuario.Email.ToLower();

                usuario.CriarHash();
                _context.Add(usuario);
                await _context.SaveChangesAsync();


                return RedirectToAction("Login", "Conta");
            }

            else
            {
                TempData["ErrorMessage"] = "Este email já esta cadastrado!";
                return View();
            }

        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(string email, string senha, int IdCrianca, Crianca crianca)
        {
            senha = senha.CriarHash();
            email = email.ToLower();

            var usuario = _context.Usuario.FirstOrDefault(u => u.Email == email && u.Senha == senha);


            if (usuario != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, usuario.NomeResp),
                    new Claim(ClaimTypes.Email, usuario.Email),
                    new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString())
                };


                if (usuario.IsAdmin == true)
                {
                    claims.Add(new Claim(ClaimTypes.Role, "Admin"));
                }
                else
                {
                    claims.Add(new Claim(ClaimTypes.Role, "Usuario"));
                }

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                int idCrianca = ObterIdCrianca(crianca);

                var UsuarioDados = new Usuario
                {
                    NomeResp = usuario.NomeResp,
                    Email = usuario.Email,
                };

                return RedirectToAction("Index", "Home");

            }
            else
            {
                TempData["ErrorMessage"] = "Email ou senha incorretos!";
            }

            return View();
        }

        public int ObterIdCrianca(Crianca crianca) 
        {
            int idCrianca = crianca.Id;
            return idCrianca;
        }
        public IActionResult ObterId() {

            return RedirectToAction("CadastroMiopia", "Home", new {Usuario = User}); 
        }
        
        
        [HttpPost]

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Cadastro","Conta");
        }


    }
}

 