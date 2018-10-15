using Microsoft.AspNetCore.Mvc;

namespace DemensProjektNewLayout.Controllers
{
    public class AccountController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}