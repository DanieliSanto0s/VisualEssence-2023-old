using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tcc.Models;

namespace Tcc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
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
        public IActionResult DaltonismoGame()
        {
            return View();
        }
        public IActionResult MiopiaGame()
        {
            return View();
        } 
        public IActionResult AstigmatismoGame()
        {
            return View();
        }
        public IActionResult MFase1()
        {
            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}