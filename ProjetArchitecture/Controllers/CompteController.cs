using Microsoft.AspNetCore.Mvc;

namespace ProjetArchitecture.Controllers
{
    public class CompteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
