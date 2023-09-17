using Microsoft.AspNetCore.Mvc;

namespace Tcc.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
