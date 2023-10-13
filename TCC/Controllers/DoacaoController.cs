using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Tcc.Controllers
{
    [Authorize]
    public class DoacaoController : Controller
    {
        public IActionResult Doacao()
        {
            return View();
        }
    }
}
