using Data_Binding_6.Models;
using Microsoft.AspNetCore.Mvc;

namespace Data_Binding_6.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult CreateProduct()
        {
            // Update için: Veritabanından ilgili product nesnesi alınıyor.
            // View'e güncellenmesi için gönderiliyor.

            Product product = new Product()
            {
                Id = 1,
                Name = "Mavi Kalem",
                Description = "Kurşun kalem",
                Quantity = 10,
                Price = 55
            };


            return View(product);
        }


        [HttpPost]
        public IActionResult CreateProduct(Product p)
        {
            // kullanıcıdan alınan Product bilgileri ile ilgili yapılacak olan işler burada yönetilir.

            return View();
        }
    }
}
