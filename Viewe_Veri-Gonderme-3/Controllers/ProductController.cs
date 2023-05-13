using Microsoft.AspNetCore.Mvc;
using Viewe_Veri_Gonderme_3.Models;

namespace Viewe_Veri_Gonderme_3.Controllers
{
    public class ProductController : Controller
    {

        // Verileri Controller'dan View'e taşımak için 6 yol var:

        // ViewData, ViewBag, TempDate, Model, Tuple, ViewModel



        #region Model ile View'e Veri Taşıma

        public IActionResult VeriTasiModel()
        {
            Product urun = new Product()
            {
                Id = 1,
                UrunAdi = "Kırmızı Kalem",
                Adet = 10,
                Fiyat = 50
            };

            // yukarıda yaratmış olduğum Product türündeki verimi View'e taşımak için burada yapacağım iş aşağıdaki View'e parametre olarak bu nesneyi vermem gerekir.

            return View(urun);
        }

        #endregion

        #region Ornek

        // Product türünde 4-5 tane nesnem var.... Bu bilgileri View'e taşımak istiyorum... Nasıl taşırım...

        public IActionResult Ornek()
        {

            List<Product> urunler = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    UrunAdi = "Mavi Kalem",
                    Adet = 20,
                    Fiyat = 30
                },
                new Product()
                {
                    Id = 2,
                    UrunAdi = "Sarı Kalem",
                    Adet = 50,
                    Fiyat = 20
                },
                new Product()
                {
                    Id = 3,
                    UrunAdi = "Yeşil Kalem",
                    Adet = 60,
                    Fiyat = 150
                },
                new Product()
                {
                    Id = 4,
                    UrunAdi = "Kırmızı Kalem",
                    Adet = 10,
                    Fiyat = 50
                },

                new Product()
                {
                    Id = 5,
                    UrunAdi = "Turuncu Kalem",
                    Adet = 50,
                    Fiyat = 520
                }

            };


            return View(urunler);

        }


        #endregion


        #region ViewData ile View'e veri gönderme

        // ViewData[key] = veri

        public IActionResult OrnekViewData()
        {
            string ad = "Ahmet";
            ViewData["isim"] = ad;
            ViewData["soyisim"] = "Yıldız";
            return View();
        }

        #endregion

        #region ViewBag ile veri taşıma

        // ViewBag.key = veri

        public IActionResult OrnekViewBag()
        {
            string ad = "Ahmet";
            ViewBag.isim = ad;
            ViewBag.sirket = "ABC Yazılım";
            return View();
        }

        #endregion


        #region TempData Kullanımı

        // TempData[key] = veri

        public IActionResult OrnekTempData()
        {
            string sirket = "Network Akademi";
            TempData["sirket"] = sirket;
            TempData["isim"] = "Mustafa";
            TempData["tur"] = "Veriler TempData ile taşındı";

            return View();
        }



        #endregion


        #region TempData ile ViewData ve ViewBag arasındaki fark?

        public IActionResult OrnekTempData1()
        {
            // kodlar yazıldı ve çalıştırıldı
            // Daha sonra geriye bir View döndürmüyorum.
            // Kısacası bu Action'ı kullanan, sonrasında mutlaka Detay Action'unu da kullanacak.
            // tempdata

            string sirket = "Network Akademi";
            TempData["sirket"] = sirket;
            TempData["isim"] = "Mustafa";
            TempData["tur"] = "Veriler TempData ile taşındı.";
            ViewBag.yas = "25";
            ViewData["sehir"] = "İstanbul";

            return RedirectToAction("Detay");
        }

        public IActionResult Detay()
        {
            // OrnekTempData1 içindeki kodlar çalıştıktan sonra bu Action'a yönlendirildiği için, bu actiondaki kodlar çalışacak.

            return View();
        }

        #endregion

        #region Tuple(tapıl) ile nesne gönderimi

        public IActionResult VeriGonderTuple()
        {
            Product urun = new Product()
            {
                Id = 1,
                UrunAdi = "Kırmızı Kalem",
                Adet = 10,
                Fiyat = 50
            };

            User user = new User() { Id = 2, UserName = "mkavusdu" };

            var urunUser = (urun, user);


            return View(urunUser);
        }
        #endregion

        #region ViewModel ile veri taşıma

        // en az 2 nesneyi View'e taşımak istiyorsam viewModel ile verilerimizi taşıyabiliriz.
        // ViewModel aslında bir class...
        // Bu class'ın içinde taşımak istediğimiz verileri tanımlıyoruz..

        public IActionResult VeriTasiViewModel()
        {
            Product urun = new Product()
            {
                Id = 1,
                UrunAdi = "Kırmızı Kalem",
                Adet = 10,
                Fiyat = 50
            };

            User user = new User() { Id = 2, UserName = "mkavusdu" };

            UserProductViewModel viewModel = new UserProductViewModel();
            viewModel.Product = urun;
            viewModel.User = user;

            return View(viewModel);
        }


        #endregion


        public IActionResult Index()
        {
            return View("/Views/Product/Deneme.cshtml");  // veya return View("Deneme"); ikisi de açar
        }
    }
}
