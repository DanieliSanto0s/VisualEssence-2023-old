using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Tcc.Context;
using Tcc.Models;


namespace Tcc.Controllers
{
    [Authorize]
    public class FeedbackController : Controller
    {
        private readonly BancoDados _context;

        public FeedbackController(BancoDados context)
        {
            _context = context; 
        }

        [HttpGet]
        public ActionResult Feedback()
        {
            var feedback = _context.Feedback.ToList();

            return View(feedback);
        }

        
    }
}
