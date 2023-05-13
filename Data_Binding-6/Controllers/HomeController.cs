using Microsoft.AspNetCore.Mvc;

namespace Data_Binding_6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
