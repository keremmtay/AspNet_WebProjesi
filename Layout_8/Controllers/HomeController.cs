using Microsoft.AspNetCore.Mvc;

namespace Layout_8.Controllers
{
    public class HomeController : Controller
    {

        // Layout: Her bir sayfada değişkenlik göstermeyen yapıları (örn; navbar, footer, menu gibi) tasarladığımız sayfalardır.

        // Bir websitesinde layout yoksa her sayfada bazı alanları tekrar tekrar yazmak zorunda kalacağız. Bu da yönetim açısından developer'lara ciddi iş yükü getirecek. Örneğin navbarda kullandığımız şirketin logosu değiştirince her sayfada bunu değiştirmek zorunda kalacağız gibi...

        // Layout dediğimiz sayfa da özünde bir View'dir ve bir cshtml dosyasıdır.

        // View içinde herhangi bir yerde oluşturabiliriz FAKAT genel olarak Views klasörü altında SHARED diye bir klasör oluştururuz ve burada konumlandırırız. Views/Shared/_Layout.cshtml

        // Değişmeyen kodlarımızı bu sayfada yazarız. Değişen kodlarımızı da nerede göstermek istiyor isek o bölümde RenderBody() dediğimiz metod ile ilgili yere render edilmesini/yerleştirilmesini sağlarız.

        // Değişen sayfalarda da yazmamız gereken kod ise aşağıdaki gibidir:
        /*
         @{Layout = "~/Views/Shared/_Layout.cshtml";} şeklinde çağırmam gerekiyor.
         */



        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Page1()
        {
            return View();
        }
        public IActionResult Page2()
        {
            return View();
        }
        public IActionResult Page3()
        {
            return View();
        }
    }
}
