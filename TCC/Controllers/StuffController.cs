using Microsoft.AspNetCore.Mvc;

namespace Tcc.Controllers
{
    public class StuffController : Controller
    {
        public IActionResult Stuff()
        {
            return View();
        }
    }
}
