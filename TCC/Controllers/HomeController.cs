using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;
using Tcc.Context;
using Tcc.Models;

namespace Tcc.Controllers
{
   [Authorize]
    public class HomeController : Controller
    {

        private readonly BancoDados _context;
 
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, BancoDados context) 
        {
            _context = context;
            _logger = logger;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Perfil()
        {
            return View();
        }

        public IActionResult Doacao()
        {
            return View();
        }
 
        

        
        [HttpPost]
        public IActionResult EnviarFeedback(Feedback feedback)
        {

            if (ModelState.IsValid)
            {
                _context.Feedback.Add(feedback);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View("Index", feedback);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}