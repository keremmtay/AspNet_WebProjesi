using Microsoft.AspNetCore.Mvc;
using TagHelper_5.Models;

namespace TagHelper_5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveUser(User user)
        {
            return View();
        }

        public IActionResult Deneme()
        {
            return View();
        }

    }
}
