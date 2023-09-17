using Microsoft.AspNetCore.Mvc;

namespace Tcc.Controllers
{
    public class FeedbackController : Controller
    {
        public IActionResult Feedback()
        {
            return View();
        }
    }
}
