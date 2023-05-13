using Microsoft.AspNetCore.Mvc;
using Uygulama_1.BusinessLayer;
using Uygulama_1.Models;

namespace Uygulama_1.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager _manager = new CategoryManager();

        [HttpGet]
        public IActionResult Index()
        {
            // Category Listele

            return View(_manager.GetAll());
        }

        [HttpPost]
        public IActionResult DeleteCategory(int id) 
        {
            _manager.Delete(id);

            return RedirectToAction("Index");
        }

        public IActionResult CategoryUpdate(Category category)
        {
            _manager.Update(category);

            return RedirectToAction("Index");
        }
    }
}
