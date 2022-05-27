using Microsoft.AspNetCore.Mvc;

namespace ProjetArchitecture.Controllers
{
    public class OperationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
