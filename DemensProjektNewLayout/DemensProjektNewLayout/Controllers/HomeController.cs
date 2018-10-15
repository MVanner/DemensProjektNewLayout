using Microsoft.AspNetCore.Mvc;

namespace DemensProjektNewLayout.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}