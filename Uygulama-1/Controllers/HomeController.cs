using Microsoft.AspNetCore.Mvc;

namespace Uygulama_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
