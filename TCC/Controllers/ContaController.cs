using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult Login(string email, string senha)
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

                if (usuario.IsAdmin)
                {
                    claims.Add(new Claim(ClaimTypes.Role, "Admin"));
                }

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToAction("Index", "Home"); // Redirecione para a página inicial


            }

            return View();
        }

        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }


    }
}

 