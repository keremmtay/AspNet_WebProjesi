using Microsoft.AspNetCore.Mvc;

namespace ViewComponent_10.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

