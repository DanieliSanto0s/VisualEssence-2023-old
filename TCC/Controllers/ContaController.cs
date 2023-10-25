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
        public IActionResult Cadastro(Usuario usuario)
        {
            if (_context.Usuario.Any(u => u.Email == usuario.Email))
            {
                ModelState.AddModelError(nameof(Usuario.Email), "Este email já está cadastrado.");
            }


            if (ModelState.IsValid)
            {
                usuario.Email = usuario.Email.ToLower();

                _context.Usuario.Add(usuario);
                _context.SaveChanges();


                Task.Delay(3000); // Atraso de 3 segundos
                return RedirectToAction("Login", "Conta");
            }
            
            return View(usuario);

        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string senha, int IdCrianca, Crianca crianca)
        {
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

                return RedirectToAction("Index", "Home");

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
            HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }


    }
}

 