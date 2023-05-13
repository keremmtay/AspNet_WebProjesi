using Microsoft.AspNetCore.Mvc;
using Validations_GelenVerilerinDogrulanmasi_7.Models;

namespace Validations_GelenVerilerinDogrulanmasi_7.Controllers
{
    public class CustomerController : Controller
    {

        // Validation İşlemleri
        // Validation: Veri Doğrulama: Örneğin kullanıcıdan alınan email bilgisinin email formatında olup olmadığını kontrol etmemiz gerekir. Yine kimlik numarası bilgisini aldığımızda bunun 11 karakter olup olmadığını kontrol etmeliyiz. 10 ya da 15 karakter olmamalı. Ürün ismi girildiğinde en az 2 en fazla 25 olması gerekiyorsa bunun da kontrolü yapılmalı. Ya da zorunlu bir alana veri girilip girilmediğinin kontrolü yapılmalıdır.
        // 2 türlü validation yapılır: 1 - Server Side Validation(Server tabanlı), 2 - Client Side Validation(Client tabanlı)


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCustomer(Customer customer)
        {
            // Controller tarafında validation işlemi yapabilmemiz için ModelState dediğimiz bir yapıyı kullanıyoruz.
            // ModelState: Veri tutan bir tipin (Product, Customer gibi) property'lerine ait Data Annotation'larının durumunu kontrol eden ve geriye bir sonuç döndüren yapıdır ya da property'dir.
            // Kısacası girilen verilerin Data Annotationlar ile belirlediğimiz kurallar çerçevesinde kontrolünü yapıyor ve sonucu bize döndürüyor. Bunu arka planda otomatik olarak yapıyor.

            if (ModelState.IsValid) 
            { 
                // girilen veriler validationdan geçmiştir. Yapılacak işlemler burada yapılır. Kaydetme, güncelleme vb.
                
                return View("CreateSuccess");
            }
            else
            {
                // veriler validationdan geçmediyse buradaki işlemler yapılır.

                return View(customer);
            }
        }

        public IActionResult CreateSuccess()
        {
            return View();
        }
    }
}
