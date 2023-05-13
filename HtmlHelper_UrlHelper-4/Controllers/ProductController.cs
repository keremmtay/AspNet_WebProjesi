using Microsoft.AspNetCore.Mvc;

namespace HtmlHelper_UrlHelper_4.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UrunleriGetir()
        {
            return View();
        }
    }
}
