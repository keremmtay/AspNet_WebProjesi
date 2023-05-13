using Microsoft.AspNetCore.Mvc;
using Validations_FluentValidation_7._1.Models;

namespace Validations_FluentValidation_7._1.Controllers
{
    public class CustomerController : Controller
    {

        // FluentValidation kütüphanesini kullanarak validation işlemleriin yapıyoruz.

        // ManageNuget Package'tan FluentValidation.AspNetCore isimli kütüphaneyi yüklüyoruz.

        // Bu servisi projemize dahil etmemiz gerekiyor. Bunun için de Program.cs dosyasına gidip ilgili satıra ilgili servisi eklemem gerekiyor.

        // Eğer Client Validation yapacak isek, ilgili paketleri öncelikle yüklememiz gerekecek.

        // 3 tane paketi yüklememiz gerekecek. Fakat bunun için öncelikle wwwroot isimli klasörü eklememiz gerekiyor.

        // wwwroot özel bir klasördür. // css, js, images gibi dosyaları barındırdığımız yer... Bu klasörü kullanabilmemiz için app.UseStaticFiles(); middleware'nin ekli olması gerekiyor Program.cs içerisinde...

        // Yüklememiz gereken paketler sırasıyla: jquery, jquery-validate, jquery-validation-unobtrusive kütüphanelerini yüklememiz gerekiyor.

        // Bunları yüklemek için wwwroot klasörünün üstüne sağ tıklayıp Add kısmından client-side-library seçmemiz gerekiyor.

        // Daha sonra bu kütüphaneleri hangi View içinde kullanacaksak oraya eklememiz gerekecek.

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
            if (ModelState.IsValid)
            {
                // Doğrulama sağlandıysa buradaki kodlar çalışacak.

                return View("CreateSuccess");
            }
            else
            {
                // Veriler doğrulanmadıysa buradaki kodlar çalışacak.

                return View(customer);


            }
        }
    }
}
